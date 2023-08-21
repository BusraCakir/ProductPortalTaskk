using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Core.ProductPortalBase.JWT
{
    public class JwtTokenOlustur
    {
        [SwaggerSchema(Description = "Token bilgisi")]
        public string AccessToken { get; set; }
        [SwaggerSchema(Description = "Token bitiş tarihi")]
        public DateTime Expiration { get; set; }
    }
}
