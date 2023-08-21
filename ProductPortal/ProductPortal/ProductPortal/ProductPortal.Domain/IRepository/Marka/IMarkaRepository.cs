using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Domain.Dtos.Marka.ItemDtos;
using ProductPortal.Entity.Entities.Marka;

namespace ProductPortal.Domain.IRepository.Marka
{
    public interface IMarkaRepository : IProductPortalRepositoryBase<MarkaEntity>
    {
        IQueryable<MarkaItemDto> GetAllQuery(bool getPassives);
    }
}
