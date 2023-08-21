using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductPortal.Core.ProductPortalBase.EntityBase;
using ProductPortal.Domain.Dtos.Model.CommandDtos;
using ProductPortal.Domain.Dtos.Model.QueryDtos;
using ProductPortal.Domain.Dtos.Urun.CommandDtos;
using ProductPortal.Domain.Dtos.Urun.QueryDtos;

namespace ProductPortal.API.CQRS.Model.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ModelController : ProductPortalControllerBase<ModelController>
    {
        public ModelController() : base() { }

        [HttpPost("GetAll"),  ActionName($"Model Tablosu Getir")]
        public async Task<GetAllModelQueryResponse> GetAll([FromBody] GetAllModelQueryRequest request) => await Mediator.Send(request);
        [HttpPost("GetById"), ActionName($"Model Getir")]
        public async Task<GetByIdModelQueryResponse> GetById([FromBody] GetByIdModelQueryRequest request) => await Mediator.Send(request);

        [HttpPost("Create"),ActionName($"Model Ekleme")]
        public async Task<CreateModelCommandResponse> Create([FromBody] CreateModelCommandRequest request) => await Mediator.Send(request);

        [HttpPost("Update"), ActionName($"Model Güncelleme")]
        public async Task<UpdateModelCommandResponse> Update([FromBody] UpdateModelCommandRequest request) => await Mediator.Send(request);
    }
}
