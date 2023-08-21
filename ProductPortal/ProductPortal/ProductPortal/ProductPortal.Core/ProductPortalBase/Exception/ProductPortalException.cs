namespace ProductPortal.Core.ProductPortalBase.Exception
{
    public class ProductPortalException : BaseException
    {
        public override string ExceptionType => nameof(ProductPortalException);
        public ProductPortalException(string message) : base(message) { }
        public ProductPortalException(string message, RankException innerException) : base(message, innerException) { }
    }
}
