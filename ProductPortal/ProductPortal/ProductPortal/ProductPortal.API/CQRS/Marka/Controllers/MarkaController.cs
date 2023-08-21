using Microsoft.AspNetCore.Mvc;
using ProductPortal.Core.ProductPortalBase.EntityBase;
using ProductPortal.Domain.Dtos.Marka.CommandDtos;
using ProductPortal.Domain.Dtos.Marka.QueryDtos;

namespace ProductPortal.API.CQRS.Marka.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class MarkaController : ProductPortalControllerBase<MarkaController>
    {
        public MarkaController() : base() { }

        [HttpPost("GetAll"), ActionName($"Marka Tablosu Getir")]
        public async Task<GetAllMarkaQueryResponse> GetAll([FromBody] GetAllMarkaQueryRequest request) => await Mediator.Send(request);
        [HttpPost("GetById"), ActionName($"Marka Getir")]
        public async Task<GetByIdMarkaQueryResponse> GetById([FromBody] GetByIdMarkaQueryRequest request) => await Mediator.Send(request);

        [HttpPost("Create"), ActionName($"Marka Ekleme")]
        public async Task<CreateMarkaCommandResponse> Create([FromBody] CreateMarkaCommandRequest request) => await Mediator.Send(request);

        [HttpPost("Update"), ActionName($"Marka Güncelleme")]
        public async Task<UpdateMarkaCommandResponse> Update([FromBody] UpdateMarkaCommandRequest request) => await Mediator.Send(request);
    }
}
