using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Domain.Dtos.Model.ItemDtos;
using ProductPortal.Entity.Entities.Model;

namespace ProductPortal.Domain.IRepository.Model
{
    public interface IModelRepository : IProductPortalRepositoryBase<ModelEntity>
    {
        IQueryable<ModelItemDto> GetAllQuery(bool getPassives);
    }
}
