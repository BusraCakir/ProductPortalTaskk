using Microsoft.AspNetCore.Mvc;
using ProductPortal.Core.ProductPortalBase.EntityBase;
using ProductPortal.Domain.Dtos.KullaniciYetki.CommandDtos;
using ProductPortal.Domain.Dtos.KullaniciYetki.QueryDtos;

namespace ProductPortal.API.CQRS.KullaniciYetki.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class KullaniciYetkiController : ProductPortalControllerBase<KullaniciYetkiController>
    {
        public KullaniciYetkiController() : base() { }

        [HttpPost("GetAll"), ActionName($"Kullanici Yetki Tablosu Getir")]
        public async Task<GetAllKullaniciYetkiQueryResponse> GetAll([FromBody] GetAllKullaniciYetkiQueryRequest request) => await Mediator.Send(request);

        [HttpPost("GetAllList"), ActionName($"Kullanýcý Yetki Tablo Getir")]
        public async Task<GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryResponse> GetAllAsList([FromBody] GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryRequest request) => await Mediator.Send(request);

        [HttpPost("Upsert"), ActionName($"Kullanýcý Yetki Güncelleme")]
        public async Task<UpsertKullaniciYetkiCommandResponse> Upsert([FromBody] UpsertKullaniciYetkiCommandRequest request) => await Mediator.Send(request);
    }
}
