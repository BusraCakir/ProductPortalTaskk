using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Core.ProductPortalBase.JWT
{
    public class TokenOlusturDto
    {
        public Guid KullaniciId { get; set; }
        public string Email { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public List<string> YetkiKodList { get; set; }
    }
}
