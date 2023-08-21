using DevExtreme.AspNet.Data;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.KullaniciYetki.QueryDtos;
using ProductPortal.Domain.IRepository.KullaniciYetki;

namespace ProductPortal.API.CQRS.KullaniciYetki.Queries
{
    public class GetAllKullaniciYetkiQueryHandler : ProductPortalHandlerBase<GetAllKullaniciYetkiQueryHandler, GetAllKullaniciYetkiQueryRequest, GetAllKullaniciYetkiQueryResponse, IKullaniciYetkiRepository>
    {
        public GetAllKullaniciYetkiQueryHandler() : base() { }
        public override async Task<GetAllKullaniciYetkiQueryResponse> Handle(GetAllKullaniciYetkiQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await Repository.GetAllList();
            var result = DataSourceLoader.Load(list, request.LoadOptions.Filter);
            return new GetAllKullaniciYetkiQueryResponse() { Data = result };
        }
    }
}
