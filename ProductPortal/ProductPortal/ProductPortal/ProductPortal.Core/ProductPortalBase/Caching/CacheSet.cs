//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Serialization;
//using ProductPortal.Core.Tool;

//namespace ProductPortal.Core.ProductPortalBase.Caching
//{
//    public class CacheSet : Attribute, IActionFilter
//    {
//        private ICacheService cacheService;
//        private string _key;
//        public CacheSet()
//        {
//            cacheService = ServiceTool.ServiceProvider.GetService<ICacheService>();
//        }

//        public void OnActionExecuted(ActionExecutedContext context)
//        {
//            if (context.Exception == null)
//            {

//                if (!string.IsNullOrEmpty(this._key))
//                {
//                    if (context.Result.GetType().Equals(typeof(ObjectResult)))
//                    {
//                        var res = ((ObjectResult)context.Result).Value;
//                        var value = JsonConvert.SerializeObject(res, new JsonSerializerSettings
//                        {
//                            ContractResolver = new CamelCasePropertyNamesContractResolver()
//                        });

//                        if (!string.IsNullOrEmpty(value))
//                        {
//                            cacheService.Add(this._key, value);
//                        }
//                    }
//                }
//            }
//        }

//        public void OnActionExecuting(ActionExecutingContext context)
//        {
//            var key = string.Empty;
//            var methodName = context.ActionDescriptor?.DisplayName;

//            var queryString = JsonConvert.SerializeObject(context.ActionArguments["request"]);

//            key = $"{methodName}-{queryString}";
//            this._key = key;
//            var res = cacheService.Get<string>(key);
//            if (res != null)
//            {
//                var contentResult = new ContentResult
//                {
//                    Content = res,
//                    ContentType = "application/json",
//                    StatusCode = 200
//                };
//                context.Result = contentResult;
//                return;
//            }
//        }

//        public void OnResultExecuted(ResultExecutedContext context)
//        {
//        }
//    }
//}
