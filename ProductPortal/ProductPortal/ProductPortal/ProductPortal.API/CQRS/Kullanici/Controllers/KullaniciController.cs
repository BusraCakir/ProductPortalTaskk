using Microsoft.AspNetCore.Mvc;
using ProductPortal.Core.ProductPortalBase.EntityBase;
using ProductPortal.Domain.Dtos.Kullanici.CommandDtos;
using ProductPortal.Domain.Dtos.Kullanici.QueryDtos;

namespace ProductPortal.API.CQRS.Kullanici.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class KullaniciController : ProductPortalControllerBase<KullaniciController>
    {
        public KullaniciController() : base() { }

        [HttpPost("GetAll"), ActionName($"Kullanici Tablosu Getir")]
        public async Task<GetAllKullaniciQueryResponse> GetAll([FromBody] GetAllKullaniciQueryRequest request) => await Mediator.Send(request);
        [HttpPost("GetById"), ActionName($"Kullanici Getir")]
        public async Task<GetByIdKullaniciQueryResponse> GetById([FromBody] GetByIdKullaniciQueryRequest request) => await Mediator.Send(request);

        [HttpPost("Create"), ActionName($"Kullanici Ekleme")]
        public async Task<CreateKullaniciCommandResponse> Create([FromBody] CreateKullaniciCommandRequest request) => await Mediator.Send(request);

        [HttpPost("Update"), ActionName($"Kullanici Güncelleme")]
        public async Task<UpdateKullaniciCommandResponse> Update([FromBody] UpdateKullaniciCommandRequest request) => await Mediator.Send(request);
    }
}
