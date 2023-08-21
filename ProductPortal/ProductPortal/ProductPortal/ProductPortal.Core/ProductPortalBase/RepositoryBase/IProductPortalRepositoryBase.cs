using ProductPortal.Core.ProductPortalBase.EntityBase;
using System.Linq.Expressions;

namespace ProductPortal.Core.ProductPortalBase.RepositoryBase
{
    public interface IProductPortalRepositoryBase<TEntity> where TEntity : class, IProductPortalEntityBase, new ()
    {
        Task<bool> Add(TEntity entity);
        Task<bool> AddRangeAsync(List<TEntity> entities);
        Task<Guid> AddThenGetId(TEntity entity);
        Task<bool> Update(TEntity entity);
        Task<bool> UpdateRange(List<TEntity> entity);
        Task<bool> Any(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeEntities);
    }
}
