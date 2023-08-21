using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductPortal.Entity.Core.BaseEntity;

namespace ProductPortal.Entity.Entities.Model
{
    public class ModelEntityConfiguration : BaseConfiguration<ModelEntity>
    {
        public override void Configure(EntityTypeBuilder<ModelEntity> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.UrunId).IsRequired();
            builder.Property(x => x.Ad).IsRequired();
            builder.Property(x => x.UrunAd).IsRequired();
        }
    }
}
