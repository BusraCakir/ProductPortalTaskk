using Microsoft.EntityFrameworkCore;
using ProductPortal.Core.ProductPortalBase.EntityBase;
using System.Linq.Expressions;

namespace ProductPortal.Core.ProductPortalBase.RepositoryBase
{
    public class ProductPortalRepositoryBase<TContext, TEntity> : ProductPortalBase<TEntity>, IProductPortalRepositoryBase<TEntity> where TEntity : class, IProductPortalEntityBase, new() where TContext : DbContext, new()
    {
        public TContext context;
        public ProductPortalRepositoryBase()
        {
            context = new TContext();
        }
        public async Task<Guid> AddThenGetId(TEntity entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            var addedRows = await context.SaveChangesAsync();

            if (addedRows > 0)
                return new Guid(addedEntity.GetDatabaseValues()["Id"].ToString());

            return Guid.Empty;
        }
        public async Task<bool> Add(TEntity entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            var addedRows = await context.SaveChangesAsync();

            return addedRows > 0;
        }
        public async Task<bool> Any(Expression<Func<TEntity, bool>> filter)
        {
            return await context.Set<TEntity>().AsQueryable().AnyAsync(filter);
        }
        public async Task<bool> Update(TEntity entity)
        {
            var modifiedEntity = context.Entry(entity);
            modifiedEntity.State = EntityState.Modified;
            var modifiedRows = await context.SaveChangesAsync();

            return modifiedRows > 0;
        }
        public async Task<bool> UpdateRange(List<TEntity> entity)
        {
            context.UpdateRange(entity);
            var modifiedRows = await context.SaveChangesAsync();
            return modifiedRows > 0;
        }
        public async Task<bool> AddRangeAsync(List<TEntity> entities)
        {
            await context.AddRangeAsync(entities);
            var addedRows = await context.SaveChangesAsync();
            return addedRows > 0;
        }
        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeEntities)
        {
            var result = context.Set<TEntity>().AsQueryable();

            var item = await result.AsNoTracking().SingleOrDefaultAsync(filter);

            return item;
        }
    }
}
