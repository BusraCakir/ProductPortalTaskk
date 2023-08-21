using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductPortal.Entity.Core.BaseEntity;

namespace ProductPortal.Entity.Entities.KullaniciYetki
{
    public class KullaniciYetkiEntityConfiguration : BaseConfiguration<KullaniciYetkiEntity>
    {
        public override void Configure(EntityTypeBuilder<KullaniciYetkiEntity> builder)
        {

            //Properties
            builder.Property(x => x.KullaniciId).IsRequired();
            builder.Property(x => x.YetkiId).IsRequired();

            //Foreign Keys
            builder.HasOne(x => x.Kullanici).WithMany().HasForeignKey(x => x.KullaniciId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Yetki).WithMany().HasForeignKey(x => x.YetkiId).IsRequired().OnDelete(DeleteBehavior.Restrict);

        }
    }
}
