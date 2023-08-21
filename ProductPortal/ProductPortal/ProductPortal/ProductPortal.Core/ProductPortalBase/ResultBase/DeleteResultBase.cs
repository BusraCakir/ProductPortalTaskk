namespace ProductPortal.Core.ProductPortalBase.ResultBase
{
    public class DeleteResultBase<TIdType> : ResultBase
    {
        public DeleteResultBase() { }
        public TIdType Id { get; set; }
    }
}
