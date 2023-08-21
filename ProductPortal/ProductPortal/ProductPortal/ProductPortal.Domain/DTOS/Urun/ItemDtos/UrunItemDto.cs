using ProductPortal.Entity.Entities.Kategori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Urun.ItemDtos
{
    public class UrunItemDto
    {
        public string Ad { get; set; }
        public double Desi { get; set; }
        public decimal Ucret { get; set; }
        public string Aciklama { get; set; }
        public int Stok { get; set; }
        public Guid KategoriId { get; set; }
        public string KategoriAd { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}
