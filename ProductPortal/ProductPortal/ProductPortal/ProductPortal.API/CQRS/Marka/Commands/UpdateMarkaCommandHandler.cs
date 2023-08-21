using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Marka.CommandDtos;
using ProductPortal.Domain.IRepository.Marka;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Marka;

namespace ProductPortal.API.CQRS.Marka.Commands
{
    public class UpdateMarkaCommandHandler : ProductPortalHandlerBase<UpdateMarkaCommandHandler, UpdateMarkaCommandRequest, UpdateMarkaCommandResponse, IMarkaRepository>
    {
        public UpdateMarkaCommandHandler() : base() { }
        public override async Task<UpdateMarkaCommandResponse> Handle(UpdateMarkaCommandRequest request, CancellationToken cancellationToken)
        {
            var marka = Map<MarkaEntity>(request);
            marka = UpsertBaseInfosToEntity<MarkaEntity>.ForUpdate(marka, CurrentUser, request.IsActive);
            bool result = await Repository.Update(marka);

            if (!result)
                throw new ProductPortalException("Marka güncellenirken bir hata oluştu!");

            return new UpdateMarkaCommandResponse() { Message = "Marka başarıyla güncellendi!" };
        }
    }
}
