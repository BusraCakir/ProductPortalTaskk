using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Domain.Dtos.Urun.ItemDtos;
using ProductPortal.Entity.Entities.Urun;

namespace ProductPortal.Domain.IRepository.Urun
{
    public interface IUrunRepository : IProductPortalRepositoryBase<UrunEntity>
    {
        IQueryable<UrunItemDto> GetAllQuery(bool getPassives);
    }
}
