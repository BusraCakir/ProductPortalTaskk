using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Marka.ItemDtos
{
    public class MarkaItemDto
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public Guid ModelId { get; set; }
        public string ModelAd { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}
