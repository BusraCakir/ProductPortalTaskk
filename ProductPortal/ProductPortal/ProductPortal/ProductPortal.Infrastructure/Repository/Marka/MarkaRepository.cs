using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Domain.Dtos.Marka.ItemDtos;
using ProductPortal.Domain.Dtos.Urun.ItemDtos;
using ProductPortal.Domain.IRepository.Marka;
using ProductPortal.Entity.Context;
using ProductPortal.Entity.Entities.Marka;

namespace ProductPortal.Infrastructure.Repository.Marka
{
    public class MarkaRepository : ProductPortalRepositoryBase<ProductPortalDbContext, MarkaEntity>, IMarkaRepository
    {
        public MarkaRepository() : base() { }
        public IQueryable<MarkaItemDto> GetAllQuery(bool getPassives)
        {
            var query = from marka in context.Marka
                        join kullanici in context.Kullanici on marka.CreatedUser equals kullanici.Id into kullaniciGroup
                        from kullanici in kullaniciGroup.DefaultIfEmpty()
                        orderby marka.Ad
                        select new MarkaItemDto
                        {
                            Ad = marka.Ad,
                            ModelAd = marka.ModelAd,
                            ModelId = marka.ModelId,
                            CreatedDate = marka.CreatedDate,
                            UpdatedDate = marka.UpdatedDate,
                            CreatedUser = marka.CreatedUser,
                            UpdatedUser = marka.UpdatedUser,
                            IsActive = marka.IsActive
    };
            if (getPassives)
            {
                return query;
            }

            return query.Where(x => x.IsActive);
        }
    }
}
