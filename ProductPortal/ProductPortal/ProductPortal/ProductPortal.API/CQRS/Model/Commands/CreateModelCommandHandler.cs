using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Model.CommandDtos;
using ProductPortal.Domain.IRepository.Model;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Model;

namespace ProductPortal.API.CQRS.Model.Commands
{

    public class CreateModelCommandHandler : ProductPortalHandlerBase<CreateModelCommandHandler, CreateModelCommandRequest, CreateModelCommandResponse, IModelRepository>
    {
        public CreateModelCommandHandler() : base() { }
        public override async Task<CreateModelCommandResponse> Handle(CreateModelCommandRequest request, CancellationToken cancellationToken)
        {
            ModelEntity entity = Map<ModelEntity>(request);
            entity = UpsertBaseInfosToEntity<ModelEntity>.ForInsert(entity, CurrentUser, false);
            bool result = await Repository.Add(entity);
            if (!result)
                throw new ProductPortalException("Kayıt Eklenirken Bir Hata Oluştu");

            return new CreateModelCommandResponse() { Id = entity.Id, Message = "Kayıt Başarıyla Eklendi" };
        }
    }
}
