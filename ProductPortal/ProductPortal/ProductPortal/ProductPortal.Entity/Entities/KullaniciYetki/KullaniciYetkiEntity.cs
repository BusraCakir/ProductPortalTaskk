using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Kullanici;
using ProductPortal.Entity.Entities.Yetki;

namespace ProductPortal.Entity.Entities.KullaniciYetki
{
    public class KullaniciYetkiEntity : BaseEntity
    {
        public KullaniciYetkiEntity() { }
        public Guid KullaniciId { get; set; }
        public Guid YetkiId { get; set; }

        //Referencial
        public KullaniciEntity Kullanici { get; set; }
        public YetkiEntity Yetki { get; set; }
    }
}
