using ProductPortal.Crypt.Attribute;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Model;

namespace ProductPortal.Entity.Entities.Marka
{
    public class MarkaEntity : BaseEntity
    {
        [NpgsqlEncrypt]
        public string Ad { get; set; }
        public Guid ModelId { get; set; }
        [NpgsqlEncrypt]
        public string ModelAd { get; set; }
        //Referencial
        public virtual ModelEntity Model { get; set; }
    }
}
