using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.IRepository.KullaniciYetki;

namespace ProductPortal.Domain.Dtos.KullaniciYetki.QueryDtos
{
    public class GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryHandler : ProductPortalHandlerBase<GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryHandler, GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryRequest, GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryResponse, IKullaniciYetkiRepository>
    {
        public GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryHandler() : base() { }
        public override async Task<GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryResponse> Handle(GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryRequest request, CancellationToken cancellationToken)
        {
                var yetkiList = await Repository.GetAllAsListByKullaniciId(request.KullaniciId);
                return new GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryResponse { Data = yetkiList };
        }
    }
}
