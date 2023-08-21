using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Domain.Dtos.Model.ItemDtos;
using ProductPortal.Domain.IRepository.Model;
using ProductPortal.Entity.Context;
using ProductPortal.Entity.Entities.Model;

namespace ProductPortal.Infrastructure.Repository.Model
{
    public class ModelRepository : ProductPortalRepositoryBase<ProductPortalDbContext, ModelEntity>, IModelRepository
    {
        public ModelRepository() : base() { }
        public IQueryable<ModelItemDto> GetAllQuery(bool getPassives)
        {
            var query = from model in context.Model
                        join kullanici in context.Kullanici on model.CreatedUser equals kullanici.Id into kullaniciGroup
                        from kullanici in kullaniciGroup.DefaultIfEmpty()
                        orderby model.Ad
                        select new ModelItemDto
                        {
                            Ad = model.Ad,
                            UrunAd = model.UrunAd,
                            UrunId = model.UrunId,
                            CreatedDate = model.CreatedDate,
                            UpdatedDate = model.UpdatedDate,
                            CreatedUser = model.CreatedUser,
                            UpdatedUser = model.UpdatedUser,
                            IsActive = model.IsActive
    };
            if (getPassives)
            {
                return query;
            }

            return query.Where(x => x.IsActive);
        }
    }
}
