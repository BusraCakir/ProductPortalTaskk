//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.AspNetCore.Mvc.Filters;
//using ProductPortal.Core.Tool;

//namespace ProductPortal.Core.ProductPortalBase.Caching
//{
//    public class CacheClear : Attribute, IActionFilter
//    {
//        private ICacheService _cacheService;

//        public CacheClear()
//        {
//            _cacheService = ServiceTool.ServiceProvider.GetService<ICacheService>();
//        }

//        public void OnActionExecuted(ActionExecutedContext context)  
//        {
//            if (context.Exception == null)
//            {
//                var methodName = context.ActionDescriptor?.DisplayName.Split("Controller.")?.First();
//                methodName += "Controller.Get";

//                _cacheService.RemoveKeyStartsWith(methodName);
//            }
//        }

//        public void OnActionExecuting(ActionExecutingContext context)
//        {
//        }

//        public void OnResultExecuted(ResultExecutedContext context)
//        {
//        }
//    }
//}
