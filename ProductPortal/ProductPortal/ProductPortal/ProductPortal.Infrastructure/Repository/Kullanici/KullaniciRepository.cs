using Microsoft.EntityFrameworkCore;
using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.Hash;
using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Core.ProductPortalBase.ResultBase;
using ProductPortal.Domain.Dtos.Kategori.ItemDtos;
using ProductPortal.Domain.Dtos.Kullanici.ItemDtos;
using ProductPortal.Domain.IRepository.Kategori;
using ProductPortal.Domain.IRepository.Kullanici;
using ProductPortal.Entity.Context;
using ProductPortal.Entity.Entities.Kullanici;

namespace ProductPortal.Infrastructure.Repository.Kullanici
{
    public class KullaniciRepository : ProductPortalRepositoryBase<ProductPortalDbContext, KullaniciEntity>, IKullaniciRepository
    {
        private readonly IBCryptHelper _cryptHelper;

        public KullaniciRepository(IBCryptHelper cryptHelper) : base()
        {
            _cryptHelper = cryptHelper;
        }

        public async Task<ResultBase> CreateKullanici(string kullaniciAdi)
        {
            using (var transaction = context.Database.BeginTransaction())
            {

                var kullaniciAdVarMi = context.Kullanici.Any(x => x.Ad == kullaniciAdi);
                if (kullaniciAdVarMi)
                    throw new ProductPortalException("Bu kullanıcı adına sahip başka bir kullanıcı bulunmaktadır. Lütfen yeni bir kullanıcı adı deneyiniz.");

                var kullanici = new KullaniciEntity
                {
                    Ad = kullaniciAdi
                };
                kullanici.PasswordSalt = _cryptHelper.GenerateSalt(13);

                kullanici.IsActive = true;

                var result = await context.Kullanici.AddAsync(kullanici);

                await context.SaveChangesAsync();

                transaction.Commit();

                return new ResultBase();
            }
        }

        //public async Task<KullaniciAvatarItemDto> GetKullaniciAvatar(Guid kullaniciId)
        //{
        //    var query = await context.Kullanici.Where(x => x.Id == kullaniciId).Select(x => new KullaniciAvatarItemDto
        //    {
        //        KullaniciId = x.Id,
        //        CepTelefonu = x.Personel.CepTelefonu,
        //        Mail = x.Personel.Mail,
        //        KullaniciAd = x.KullaniciAdi,
        //        SMSDogrulama = x.SmsDogrulamaAktifMi,
        //        SonGirisTarihi = x.SonGirisTarihi.HasValue ? x.SonGirisTarihi.Value.ToString("dd/MM/yyyy hh:mm") : "",
        //        PersonelAd = x.Personel.Ad,
        //        PersonelSoyad = x.Personel.Soyad,
        //        PersonelId = x.PersonelId,
        //        SmsDogrulamaDisplay = x.SmsDogrulamaAktifMi == true ? "Aktif" : "Pasif",
        //        KullaniciCinsiyet = x.Personel.Cinsiyet

        //    }).FirstOrDefaultAsync();
        //    return query;
        //}

        public IQueryable<KullaniciItemDto> GetAllQuery(bool getPassives)
        {
            return context.Kullanici.Select(x => new KullaniciItemDto
            {
                Id = x.Id,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Password = x.Password,
                CreatedDate = x.CreatedDate,
                CreatedUser = x.CreatedUser,
                IsActive = x.IsActive,
                UpdatedDate = x.UpdatedDate,
                UpdatedUser = x.UpdatedUser,
            });
        }
        //public async Task<DataResultBase<string>> ForgetPassword(string mail)
        //{

        //    string sifreGuid = Guid.NewGuid().ToString();

        //    return new DataResultBase<string>() { Data = sifreGuid };
        //}
        public async Task<KullaniciEntity> GetKullaniciByKullaniciAdiOrEpostaQuery(string kullaniciAdi)
        {
            var kullanici = await context.Kullanici.FirstOrDefaultAsync(x => (x.Ad == kullaniciAdi) && x.IsActive);
            
            return kullanici;

        }
        public async Task<ResultBase> LastLoginDateUpdate(Guid kullaniciId)
        {
            var kullanici = await context.Kullanici.FirstOrDefaultAsync(x => x.Id == kullaniciId);
            kullanici.SonGirisTarihi = DateTime.Now;
            await context.SaveChangesAsync();
            return new ResultBase(true);
        }
    }
}
