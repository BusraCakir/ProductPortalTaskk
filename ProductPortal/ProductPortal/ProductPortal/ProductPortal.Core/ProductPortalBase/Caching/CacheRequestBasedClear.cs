//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Newtonsoft.Json;
//using ProductPortal.Core.Tool;

//namespace ProductPortal.Core.ProductPortalBase.Caching
//{
//    public class CacheRequestBasedClear : Attribute, IActionFilter
//    {
//        private ICacheService _cacheService;
//        private string CachedControllerName = string.Empty;

//        public CacheRequestBasedClear()
//        {
//            _cacheService = ServiceTool.ServiceProvider.GetService<ICacheService>();
//        }

//        public void OnActionExecuted(ActionExecutedContext context)
//        {
//            if (context.Exception == null)
//                _cacheService.RemoveKeyContains($"{CachedControllerName}Controller.Get");
//        }

//        public void OnActionExecuting(ActionExecutingContext context)
//        {
//            string requestJson = JsonConvert.SerializeObject(context.ActionArguments["request"]);
//            CacheRequestBasedClearDto dto = JsonConvert.DeserializeObject<CacheRequestBasedClearDto>(requestJson);
//            CachedControllerName = Enum.GetName(dto.ModuleEnum);
//        }

//        public void OnResultExecuted(ResultExecutedContext context)
//        {
//        }
//    }
//}
