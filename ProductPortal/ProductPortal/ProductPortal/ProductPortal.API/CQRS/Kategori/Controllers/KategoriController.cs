using Microsoft.AspNetCore.Mvc;
using ProductPortal.Core.ProductPortalBase.EntityBase;
using ProductPortal.Domain.Dtos.Kategori.CommandDtos;
using ProductPortal.Domain.Dtos.Kategori.QueryDtos;

namespace ProductPortal.API.CQRS.Kategori.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class KategoriController : ProductPortalControllerBase<KategoriController>
    {
        public KategoriController() : base() { }

        [HttpPost("GetAll"), ActionName($"Kategori Tablosu Getir")]
        public async Task<GetAllKategoriQueryResponse> GetAll([FromBody] GetAllKategoriQueryRequest request) => await Mediator.Send(request);
        [HttpPost("GetById"), ActionName($"Kategori Getir")]
        public async Task<GetByIdKategoriQueryResponse> GetById([FromBody] GetByIdKategoriQueryRequest request) => await Mediator.Send(request);

        [HttpPost("Create"), ActionName($"Kategori Ekleme")]
        public async Task<CreateKategoriCommandResponse> Create([FromBody] CreateKategoriCommandRequest request) => await Mediator.Send(request);

        [HttpPost("Update"), ActionName($"Kategori Güncelleme")]
        public async Task<UpdateKategoriCommandResponse> Update([FromBody] UpdateKategoriCommandRequest request) => await Mediator.Send(request);
    }
}
