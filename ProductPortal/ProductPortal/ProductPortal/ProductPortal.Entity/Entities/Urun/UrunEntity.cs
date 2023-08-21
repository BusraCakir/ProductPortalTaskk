using ProductPortal.Crypt.Attribute;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Kategori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Entity.Entities.Urun
{
    public class UrunEntity : BaseEntity
    {
        [NpgsqlEncrypt]
        public string Ad { get; set; }
        public double Desi { get; set; }
        public decimal Ucret { get; set; }
        public string Aciklama { get; set; }
        public int Stok { get; set; }
        public Guid KategoriId { get; set; }
        [NpgsqlEncrypt]
        public string KategoriAd { get; set; }

        //Referencial
        public virtual KategoriEntity Kategori { get; set; }
    }
}
