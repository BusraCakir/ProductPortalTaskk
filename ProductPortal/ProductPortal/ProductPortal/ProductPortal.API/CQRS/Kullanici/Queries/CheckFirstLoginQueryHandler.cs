using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Kullanici.QueryDtos;
using ProductPortal.Domain.IRepository.Kullanici;

namespace ProductPortal.API.CQRS.Kullanici.Queries
{

    public class CheckFirstLoginQueryHandler : ProductPortalHandlerBase<CheckFirstLoginQueryHandler, CheckFirstLoginStatusQueryRequest, CheckFirstLoginStatusQueryResponse, IKullaniciRepository>
    {
        public CheckFirstLoginQueryHandler() : base() { }
        public override async Task<CheckFirstLoginStatusQueryResponse> Handle(CheckFirstLoginStatusQueryRequest request, CancellationToken cancellationToken)
        {
            var kullanici = await Repository.Get(x => x.Id == CurrentUser.KullaniciId.Value);
            return new CheckFirstLoginStatusQueryResponse { Data = kullanici.IsFirstLogin };
        }
    }
}