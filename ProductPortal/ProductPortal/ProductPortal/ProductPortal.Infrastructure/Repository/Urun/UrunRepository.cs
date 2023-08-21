using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Domain.Dtos.Urun.ItemDtos;
using ProductPortal.Domain.IRepository.Urun;
using ProductPortal.Entity.Context;
using ProductPortal.Entity.Entities.Urun;

namespace ProductPortal.Infrastructure.Repository.Urun
{
    public class UrunRepository : ProductPortalRepositoryBase<ProductPortalDbContext, UrunEntity>, IUrunRepository
    {
        public UrunRepository() : base() { }
        public IQueryable<UrunItemDto> GetAllQuery(bool getPassives)
        {
            var query = from urun in context.Urun
                        join kullanici in context.Kullanici on urun.CreatedUser equals kullanici.Id into kullaniciGroup
                        from kullanici in kullaniciGroup.DefaultIfEmpty()
                        orderby urun.Ad
                        select new UrunItemDto
                        {
                            Ad = urun.Ad,
                            Desi = urun.Desi,
                            Ucret = urun.Ucret,
                            Aciklama = urun.Aciklama,
                            Stok = urun.Stok,
                            KategoriId = urun.KategoriId,
                            KategoriAd = urun.KategoriAd,
                            CreatedDate = urun.CreatedDate,
                            UpdatedDate = urun.UpdatedDate,
                            CreatedUser = urun.CreatedUser,
                            UpdatedUser = urun.UpdatedUser,
                            IsActive = urun.IsActive
                        };
            if (getPassives)
            {
                return query;
            }

            return query.Where(x => x.IsActive);
        }
    }
}
