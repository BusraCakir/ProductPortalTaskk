using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Marka.CommandDtos;
using ProductPortal.Domain.IRepository.Marka;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Marka;
namespace ProductPortal.API.CQRS.Marka.Commands
{
    public class CreateMarkaCommandHandler : ProductPortalHandlerBase<CreateMarkaCommandHandler, CreateMarkaCommandRequest, CreateMarkaCommandResponse, IMarkaRepository>
    {
        public CreateMarkaCommandHandler() : base() { }
        public override async Task<CreateMarkaCommandResponse> Handle(CreateMarkaCommandRequest request, CancellationToken cancellationToken)
        {
            MarkaEntity entity = Map<MarkaEntity>(request);
            entity = UpsertBaseInfosToEntity<MarkaEntity>.ForInsert(entity, CurrentUser, false);
            bool result = await Repository.Add(entity);
            if (!result)
                throw new ProductPortalException("Kayıt Eklenirken Bir Hata Oluştu");

            return new CreateMarkaCommandResponse() { Id = entity.Id, Message = "Kayıt Başarıyla Eklendi" };
        }
    }
}
