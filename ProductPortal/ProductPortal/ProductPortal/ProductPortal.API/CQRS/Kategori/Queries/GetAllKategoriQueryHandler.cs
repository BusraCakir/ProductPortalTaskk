using DevExtreme.AspNet.Data;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Kategori.QueryDtos;
using ProductPortal.Domain.IRepository.Kategori;

namespace ProductPortal.API.CQRS.Kategori.Queries
{
    public class GetAllKategoriQueryHandler : ProductPortalHandlerBase<GetAllKategoriQueryHandler, GetAllKategoriQueryRequest, GetAllKategoriQueryResponse, IKategoriRepository>
    {
        public GetAllKategoriQueryHandler() : base() { }
        public override async Task<GetAllKategoriQueryResponse> Handle(GetAllKategoriQueryRequest request, CancellationToken cancellationToken)
        {
            var query = Repository.GetAllQuery(request.GetPassives);
            request.LoadOptions = DevExSetDefaultFilter(request.LoadOptions, "CreatedDate");
            var result = await DataSourceLoader.LoadAsync(query, request.LoadOptions.Filter);
            return new GetAllKategoriQueryResponse() { Data = result };
        }
    }
}
