using DevExtreme.AspNet.Data;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Urun.QueryDtos;
using ProductPortal.Domain.IRepository.Urun;

namespace ProductPortal.API.CQRS.Urun.Queries
{
    public class GetAllUrunQueryHandler : ProductPortalHandlerBase<GetAllUrunQueryHandler, GetAllUrunQueryRequest, GetAllUrunQueryResponse, IUrunRepository>
    {
        public GetAllUrunQueryHandler() : base() { }
        public override async Task<GetAllUrunQueryResponse> Handle(GetAllUrunQueryRequest request, CancellationToken cancellationToken)
        {
            var query = Repository.GetAllQuery(request.GetPassives);
            request.LoadOptions = DevExSetDefaultFilter(request.LoadOptions, "CreatedDate");
            var result = await DataSourceLoader.LoadAsync(query, request.LoadOptions.Filter);
            return new GetAllUrunQueryResponse() { Data = result };
        }
    }
}
