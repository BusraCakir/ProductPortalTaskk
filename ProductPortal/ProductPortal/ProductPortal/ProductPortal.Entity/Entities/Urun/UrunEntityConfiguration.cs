using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Urun;

namespace ProductPortal.Entity.Entities.Urun
{
    public class UrunEntityConfiguration : BaseConfiguration<UrunEntity>
    {
        public override void Configure(EntityTypeBuilder<UrunEntity> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ad).IsRequired();
            builder.Property(x => x.Desi).IsRequired();
            builder.Property(x => x.Ucret).IsRequired();
            builder.Property(x => x.Aciklama).IsRequired(false);
            builder.Property(x => x.Stok).IsRequired();
            builder.Property(x => x.KategoriId).IsRequired();
            builder.Property(x => x.KategoriAd).IsRequired();
        }
    }
}
