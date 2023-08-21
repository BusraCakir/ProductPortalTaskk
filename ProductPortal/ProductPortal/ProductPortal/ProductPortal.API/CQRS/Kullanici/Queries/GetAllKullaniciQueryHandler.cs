using DevExtreme.AspNet.Data;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Kullanici.QueryDtos;
using ProductPortal.Domain.IRepository.Kullanici;

namespace ProductPortal.API.CQRS.Kullanici.Queries
{
    public class GetAllKullaniciQueryHandler : ProductPortalHandlerBase<GetAllKullaniciQueryHandler, GetAllKullaniciQueryRequest, GetAllKullaniciQueryResponse, IKullaniciRepository>
    {
        public GetAllKullaniciQueryHandler() : base() { }
        public override async Task<GetAllKullaniciQueryResponse> Handle(GetAllKullaniciQueryRequest request, CancellationToken cancellationToken)
        {
            var query = Repository.GetAllQuery(request.GetPassives);
            request.LoadOptions = DevExSetDefaultFilter(request.LoadOptions, "CreatedDate");
            var result = await DataSourceLoader.LoadAsync(query, request.LoadOptions.Filter);
            return new GetAllKullaniciQueryResponse() { Data = result };
        }
    }
}
