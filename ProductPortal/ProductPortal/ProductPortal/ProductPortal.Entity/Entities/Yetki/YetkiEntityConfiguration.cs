using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductPortal.Entity.Core.BaseEntity;

namespace ProductPortal.Entity.Entities.Yetki
{
    public class YetkiEntityConfiguration : BaseConfiguration<YetkiEntity>
    {
        public override void Configure(EntityTypeBuilder<YetkiEntity> builder)
        {
            //Properties
            builder.Property(x => x.Ad).IsRequired();
            builder.Property(x => x.Kod).IsRequired();

        }
    }
}
