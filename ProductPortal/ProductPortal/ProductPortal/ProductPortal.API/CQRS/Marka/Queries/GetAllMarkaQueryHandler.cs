using DevExtreme.AspNet.Data;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Marka.QueryDtos;
using ProductPortal.Domain.IRepository.Marka;

namespace ProductPortal.API.CQRS.Marka.Queries
{
    public class GetAllMarkaQueryHandler : ProductPortalHandlerBase<GetAllMarkaQueryHandler, GetAllMarkaQueryRequest, GetAllMarkaQueryResponse, IMarkaRepository>
    {
        public GetAllMarkaQueryHandler() : base() { }
        public override async Task<GetAllMarkaQueryResponse> Handle(GetAllMarkaQueryRequest request, CancellationToken cancellationToken)
        {
            var query = Repository.GetAllQuery(request.GetPassives);
            request.LoadOptions = DevExSetDefaultFilter(request.LoadOptions, "CreatedDate");
            var result = await DataSourceLoader.LoadAsync(query, request.LoadOptions.Filter);
            return new GetAllMarkaQueryResponse() { Data = result };
        }
    }
}
