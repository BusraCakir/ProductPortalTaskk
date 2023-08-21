using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ProductPortal.Core.CurrentUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Core.ProductPortalBase.JWT
{
    public static class JwtResolveCurrentUser
    {
        public static CurrentUserDto ResolveCurrentUser(IHttpContextAccessor contextAccessor)
        {
            var currentUser = new CurrentUserDto();

            if (contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) != null)
            {
                currentUser.KullaniciId.Value = Guid.Parse(contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                currentUser.KullaniciId.IsExist = true;
            }
            if (contextAccessor.HttpContext.User.FindFirstValue("yetkiJson") != null)
            {
                currentUser.YetkiKodList.Value = JsonConvert.DeserializeObject<List<string>>(contextAccessor.HttpContext.User.FindFirstValue("yetkiJson"));
                currentUser.YetkiKodList.IsExist = true;
            }
            return currentUser;
        }
    }
}
