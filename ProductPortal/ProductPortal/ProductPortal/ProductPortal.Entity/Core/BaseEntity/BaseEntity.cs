using ProductPortal.Core.ProductPortalBase.EntityBase;
namespace ProductPortal.Entity.Core.BaseEntity
{
    public class BaseEntity : IProductPortalEntityBase
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid CreatedUser { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}
