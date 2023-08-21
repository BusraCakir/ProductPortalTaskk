using Microsoft.EntityFrameworkCore;
using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Domain.Dtos.KullaniciYetki.ItemDtos;
using ProductPortal.Domain.Dtos.Yetki.ItemDtos;
using ProductPortal.Domain.IRepository.KullaniciYetki;
using ProductPortal.Entity.Context;
using ProductPortal.Entity.Entities.KullaniciYetki;

namespace ProductPortal.Infrastructure.Repository.Kullanici
{
    public class KullaniciYetkiRepository : ProductPortalRepositoryBase<ProductPortalDbContext, KullaniciYetkiEntity>, IKullaniciYetkiRepository
    {
        public async Task<List<YetkiItemDto>> GetAllAsListByKullaniciId(Guid kullaniciId)
            => await context.KullaniciYetki.Where(x => x.KullaniciId == kullaniciId && x.IsActive == true).Select(x => new YetkiItemDto
            {
                Id = x.Yetki.Id,
                Kod = x.Yetki.Kod,
                Ad = x.Yetki.Ad
            }).ToListAsync();

        public async Task<List<KullaniciYetkiListItemDto>> GetAllList()
        {
            var result = await context.Kullanici.Where(x => x.IsActive).Select(x => new KullaniciYetkiListItemDto
            {
                KullaniciId = x.Id,
            }).ToListAsync();

            result.ForEach(data =>
            {
                data.YetkiList = (from yetki in context.Yetki
                                  join kYetki in context.KullaniciYetki.Where(x => x.KullaniciId == data.KullaniciId) on yetki.Id equals kYetki.YetkiId into joinedYK
                                  from kYetki in joinedYK.DefaultIfEmpty()
                                  select new KullaniciYetkiListDetailItemDto
                                  {
                                      DuzenlenmeTarihi = kYetki.UpdatedDate,
                                      KullaniciYetkiId = kYetki != null ? kYetki.Id : Guid.Empty,
                                      YetkiAd = yetki.Ad,
                                      YetkiId = yetki.Id,
                                      YetkiKod = yetki.Kod,
                                      Yetkili = kYetki != null ? kYetki.IsActive : false
                                  }).OrderBy(x => x.YetkiKod).ToList();

            });

            return result;
        }
        public async Task<bool> UpsertKullaniciYetki(List<KullaniciYetkiListItemDto> upsertList)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    foreach (var item in upsertList)
                    {
                        var kullaniciYetkiModelList = item.YetkiList.Select(kullaniciYetki => new KullaniciYetkiEntity
                        {
                            Id = kullaniciYetki.KullaniciYetkiId,
                            IsActive = kullaniciYetki.Yetkili,
                            KullaniciId = item.KullaniciId,
                            UpdatedDate = DateTime.Now,
                            UpdatedUser = CurrentUser.KullaniciId.Value,
                            YetkiId = kullaniciYetki.YetkiId
                        }).ToList();
                        context.UpdateRange(kullaniciYetkiModelList);
                    }

                    await context.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return true;
                }
                catch (Exception e)
                {
                    await context.SaveChangesAsync();
                    throw new ProductPortalException($"Hata: {e.Message}. нч Hata: {e.InnerException?.Message}");
                }
            }
        }
    }
}