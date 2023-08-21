using ProductPortal.Core.ProductPortalBase.RepositoryBase;
using ProductPortal.Domain.Dtos.Kategori.ItemDtos;
using ProductPortal.Domain.IRepository.Kategori;
using ProductPortal.Entity.Context;
using ProductPortal.Entity.Entities.Kategori;

namespace ProductPortal.Infrastructure.Repository.Kategori
{
    public class KategoriRepository : ProductPortalRepositoryBase<ProductPortalDbContext, KategoriEntity>, IKategoriRepository
    {
        public KategoriRepository() : base() { }
        public IQueryable<KategoriItemDto> GetAllQuery(bool getPassives)
        {
            var query = from kategori in context.Kategori
                        join kullanici in context.Kullanici on kategori.CreatedUser equals kullanici.Id into kullaniciGroup
                        from kullanici in kullaniciGroup.DefaultIfEmpty()
                        orderby kategori.Ad
                        select new KategoriItemDto
                        {
                            Ad = kategori.Ad,
                            CreatedDate = kategori.CreatedDate,
                            UpdatedDate = kategori.UpdatedDate,
                            CreatedUser = kategori.CreatedUser,
                            UpdatedUser = kategori.UpdatedUser,
                            IsActive = kategori.IsActive
                        };
            if (getPassives)
            {
                return query;
            }

            return query.Where(x => x.IsActive);
        }
    }
}
