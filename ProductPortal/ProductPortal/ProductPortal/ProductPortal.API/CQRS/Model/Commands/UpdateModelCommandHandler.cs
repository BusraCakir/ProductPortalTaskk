using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Model.CommandDtos;
using ProductPortal.Domain.IRepository.Model;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Model;

namespace ProductPortal.API.CQRS.Model.Commands
{

    public class UpdateModelCommandHandler : ProductPortalHandlerBase<UpdateModelCommandHandler, UpdateModelCommandRequest, UpdateModelCommandResponse, IModelRepository>
    {
        public UpdateModelCommandHandler() : base() { }
        public override async Task<UpdateModelCommandResponse> Handle(UpdateModelCommandRequest request, CancellationToken cancellationToken)
        {
            var hediye = Map<ModelEntity>(request);
            hediye = UpsertBaseInfosToEntity<ModelEntity>.ForUpdate(hediye, CurrentUser, request.IsActive);
            bool result = await Repository.Update(hediye);

            if (!result)
                throw new ProductPortalException("Model güncellenirken bir hata oluştu!");

            return new UpdateModelCommandResponse() { Message = "Model başarıyla güncellendi!" };
        }
    }
}
