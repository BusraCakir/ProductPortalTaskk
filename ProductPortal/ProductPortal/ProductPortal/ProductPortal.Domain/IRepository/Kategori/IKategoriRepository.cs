using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Domain.Dtos.Kategori.ItemDtos;
using ProductPortal.Entity.Entities.Kategori;

namespace ProductPortal.Domain.IRepository.Kategori
{
    public interface IKategoriRepository : IProductPortalRepositoryBase<KategoriEntity>
    {
        IQueryable<KategoriItemDto> GetAllQuery(bool getPassives);
    }
}
