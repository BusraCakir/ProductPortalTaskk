using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductPortal.Entity.Core.BaseEntity;

namespace ProductPortal.Entity.Entities.Kategori
{
    public class KategoriEntityConfiguration : BaseConfiguration<KategoriEntity>
    {
        public override void Configure(EntityTypeBuilder<KategoriEntity> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ad).IsRequired();
        }
    }
}
