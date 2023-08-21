using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Kategori.ItemDtos
{
    public class KategoriItemDto
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}
