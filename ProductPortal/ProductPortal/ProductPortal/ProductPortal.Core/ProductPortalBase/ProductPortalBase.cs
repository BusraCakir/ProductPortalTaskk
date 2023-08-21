using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ProductPortal.Core.CurrentUserDtos;
using ProductPortal.Core.ProductPortalBase.JWT;
using ProductPortal.Core.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Core.ProductPortalBase
{
    public class ProductPortalBase<THandler>
    {
        protected readonly IMediator Mediator;
        protected readonly IHttpContextAccessor _httpContextAccessor;
        protected readonly CurrentUserDto CurrentUser;
        public ProductPortalBase()
        {
            Mediator = ServiceTool.ServiceProvider.GetService<IMediator>();
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
            CurrentUser = _httpContextAccessor.HttpContext != null ? JwtResolveCurrentUser.ResolveCurrentUser(_httpContextAccessor) : null;
        }
    }
}
