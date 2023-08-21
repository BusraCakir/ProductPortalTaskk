using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Core.ProductPortalBase.ResultBase;
using ProductPortal.Domain.Dtos.Kullanici.ItemDtos;
using ProductPortal.Entity.Entities.Kullanici;

namespace ProductPortal.Domain.IRepository.Kullanici
{
    public interface IKullaniciRepository : IProductPortalRepositoryBase<KullaniciEntity>
    {
        Task<ResultBase> CreateKullanici(string kullaniciAdi);
        Task<KullaniciEntity> GetKullaniciByKullaniciAdiOrEpostaQuery(string kullaniciAdi);
        IQueryable<KullaniciItemDto> GetAllQuery(bool getPassives);
        Task<ResultBase> LastLoginDateUpdate(Guid kullaniciId);
    }
}
