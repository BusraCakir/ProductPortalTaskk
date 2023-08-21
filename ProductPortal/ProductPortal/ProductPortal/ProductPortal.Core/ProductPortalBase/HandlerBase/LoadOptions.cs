using DevExtreme.AspNet.Mvc;

namespace ProductPortal.Core.ProductPortalBase.HandlerBase
{
    public class LoadOptions
    {
        public DataSourceLoadOptions Filter { get; set; }
    }
    public class LoadOptionCustom<T> : LoadOptions
    {
        public T CustomFilter { get; set; }
    }
}
