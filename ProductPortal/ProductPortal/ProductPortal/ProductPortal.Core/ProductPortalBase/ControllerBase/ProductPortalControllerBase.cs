using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ProductPortal.Core.Tool;

namespace ProductPortal.Core.ProductPortalBase.EntityBase
{
    public class  ProductPortalControllerBase <TController> : ControllerBase
    {

        protected readonly IMediator Mediator;

        public ProductPortalControllerBase()
        {
            Mediator = ServiceTool.ServiceProvider.GetService<IMediator>();
        }
    }
}
