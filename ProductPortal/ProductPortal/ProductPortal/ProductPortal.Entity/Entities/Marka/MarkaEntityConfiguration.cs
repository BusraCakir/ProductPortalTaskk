using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductPortal.Entity.Core.BaseEntity;

namespace ProductPortal.Entity.Entities.Marka
{
    public class MarkaEntityConfiguration : BaseConfiguration<MarkaEntity>
    {
        public override void Configure(EntityTypeBuilder<MarkaEntity> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.ModelId).IsRequired();
            builder.Property(x => x.Ad).IsRequired();
            builder.Property(x => x.ModelAd).IsRequired();
        }
    }
}
