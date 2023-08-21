using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Core.ProductPortalBase.JWT
{
    public class SecurityKeyHelper
    {
        public static SecurityKey SecurityKeyOlustur(string securityKey) => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
    }
}
