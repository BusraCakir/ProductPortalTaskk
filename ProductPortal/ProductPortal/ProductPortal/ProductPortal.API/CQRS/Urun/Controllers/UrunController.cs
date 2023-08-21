using Microsoft.AspNetCore.Mvc;
using ProductPortal.Core.ProductPortalBase.EntityBase;
using ProductPortal.Domain.Dtos.Urun.CommandDtos;
using ProductPortal.Domain.Dtos.Urun.QueryDtos;

namespace ProductPortal.API.CQRS.Urun.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UrunController : ProductPortalControllerBase<UrunController>
    {
        public UrunController() : base() { }

        [HttpPost("GetAll"), ActionName($"Ürün Tablosu Getir")]
        public async Task<GetAllUrunQueryResponse> GetAll([FromBody] GetAllUrunQueryRequest request) => await Mediator.Send(request);
        [HttpPost("GetById"), ActionName($"Ürün Getir")]
        public async Task<GetByIdUrunQueryResponse> GetById([FromBody] GetByIdUrunQueryRequest request) => await Mediator.Send(request);

        [HttpPost("Create"),  ActionName($"Ürün Ekleme")]
        public async Task<CreateUrunCommandResponse> Create([FromBody] CreateUrunCommandRequest request) => await Mediator.Send(request);

        [HttpPost("Update"), ActionName($"Ürün Güncelleme")]
        public async Task<UpdateUrunCommandResponse> Update([FromBody] UpdateUrunCommandRequest request) => await Mediator.Send(request);
    }
}
