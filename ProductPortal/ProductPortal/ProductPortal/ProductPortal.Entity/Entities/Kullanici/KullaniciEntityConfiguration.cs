using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductPortal.Entity.Core.BaseEntity;
namespace ProductPortal.Entity.Entities.Kullanici
{
    public class KullaniciEntityConfiguration : BaseConfiguration<KullaniciEntity>
    {
        public override void Configure(EntityTypeBuilder<KullaniciEntity> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ad).IsRequired();
            builder.Property(x => x.Soyad).IsRequired();
            builder.Property(x => x.Email).IsRequired(false);
            builder.Property(x => x.CepNumarasi).IsRequired(false);
            builder.Property(x => x.TCKimlikNo).IsRequired();
            builder.Property(x => x.Password).IsRequired();
        }
    }
}
