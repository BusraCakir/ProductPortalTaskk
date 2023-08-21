using Swashbuckle.AspNetCore.Annotations;

namespace ProductPortal.Core.ProductPortalBase.ResultBase
{
    public class ResultBase
    {
        public ResultBase(bool _status = true, string _message = "İşlem Başarılı!")
        {
            this.Status = _status;
            this.Message = _message;
        }

        [SwaggerSchema(Description = "İşlemin başarıyla yada başarısız olarak tamamlandığının bilgisi")]
        public bool Status { get; set; }
        [SwaggerSchema(Description = "İşlemin sonucunun mesaj bilgisi")]
        public string Message { get; set; }
        [SwaggerSchema(Description = "İşlem yapılırken hata ile karşılaşıldığında hata mesajının bilgisi")]
        public string ExceptionMessage { get; set; }
    }
}
