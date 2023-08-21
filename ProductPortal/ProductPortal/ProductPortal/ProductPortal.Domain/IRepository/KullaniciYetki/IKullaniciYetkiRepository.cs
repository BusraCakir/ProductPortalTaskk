using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Core.ProductPortalBase.ResultBase;
using ProductPortal.Domain.Dtos.KullaniciYetki.ItemDtos;
using ProductPortal.Domain.Dtos.Yetki.ItemDtos;
using ProductPortal.Entity.Entities.KullaniciYetki;

namespace ProductPortal.Domain.IRepository.KullaniciYetki
{
    public interface IKullaniciYetkiRepository : IProductPortalRepositoryBase<KullaniciYetkiEntity>
    {
        Task<List<KullaniciYetkiListItemDto>> GetAllList();
        Task<List<YetkiItemDto>> GetAllAsListByKullaniciId(Guid kullaniciId);
        Task<bool> UpsertKullaniciYetki(List<KullaniciYetkiListItemDto> upsertList);
    }
}