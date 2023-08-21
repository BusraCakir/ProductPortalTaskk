using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Model.ItemDtos
{
    public class ModelItemDto
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public Guid UrunId { get; set; }
        public string UrunAd { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}
