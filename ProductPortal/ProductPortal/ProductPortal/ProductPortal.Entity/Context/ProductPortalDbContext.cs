using Microsoft.EntityFrameworkCore;
using ProductPortal.Entity.Entities.Kategori;
using ProductPortal.Entity.Entities.Kullanici;
using ProductPortal.Entity.Entities.KullaniciYetki;
using ProductPortal.Entity.Entities.Marka;
using ProductPortal.Entity.Entities.Model;
using ProductPortal.Entity.Entities.Urun;
using ProductPortal.Entity.Entities.Yetki;

namespace ProductPortal.Entity.Context
{
    public class ProductPortalDbContext : DbContext
    {
        public DbSet<KullaniciEntity> Kullanici { get; set; }
        public DbSet<UrunEntity> Urun { get; set; }
        public DbSet<ModelEntity> Model { get; set; }
        public DbSet<MarkaEntity> Marka { get; set; }
        public DbSet<KategoriEntity> Kategori { get; set; }
        public DbSet<KullaniciYetkiEntity> KullaniciYetki { get; set; }
        public DbSet<YetkiEntity> Yetki { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KullaniciEntityConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciYetkiEntityConfiguration());
            modelBuilder.ApplyConfiguration(new YetkiEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MarkaEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ModelEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UrunEntityConfiguration());
            modelBuilder.ApplyConfiguration(new KategoriEntityConfiguration());
        }
    }
}
