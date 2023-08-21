using DevExtreme.AspNet.Data;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Model.QueryDtos;
using ProductPortal.Domain.IRepository.Model;

namespace ProductPortal.API.CQRS.Model.Queries
{
    public class GetAllModelQueryHandler : ProductPortalHandlerBase<GetAllModelQueryHandler, GetAllModelQueryRequest, GetAllModelQueryResponse, IModelRepository>
    {
        public GetAllModelQueryHandler() : base() { }
        public override async Task<GetAllModelQueryResponse> Handle(GetAllModelQueryRequest request, CancellationToken cancellationToken)
        {
            var query = Repository.GetAllQuery(request.GetPassives);
            request.LoadOptions = DevExSetDefaultFilter(request.LoadOptions, "CreatedDate");
            var result = await DataSourceLoader.LoadAsync(query, request.LoadOptions.Filter);
            return new GetAllModelQueryResponse() { Data = result };
        }
    }
}
