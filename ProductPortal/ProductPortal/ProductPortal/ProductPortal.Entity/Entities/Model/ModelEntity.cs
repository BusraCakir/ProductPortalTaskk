using ProductPortal.Crypt.Attribute;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Urun;

namespace ProductPortal.Entity.Entities.Model
{
    public class ModelEntity : BaseEntity
    {
        [NpgsqlEncrypt]
        public string Ad { get; set; }
        public Guid UrunId { get; set; }
        [NpgsqlEncrypt]
        public string UrunAd { get; set; }

        //Referencial
        public virtual UrunEntity Urun { get; set; }
    }
}
