using Swashbuckle.AspNetCore.Annotations;

namespace ProductPortal.Core.ProductPortalBase.ResultBase
{
    public class DataResultBase<TData> : ResultBase
    {
        public DataResultBase(bool _status = true, string _message = "İşlem Başarılı!") : base(_status, _message)
        {
        }
        [SwaggerSchema(Description = "Dönen Data bilgisi")]
        public TData Data { get; set; }
    }
}
