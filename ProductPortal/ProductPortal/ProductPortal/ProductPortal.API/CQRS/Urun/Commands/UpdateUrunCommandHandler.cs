using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Urun.CommandDtos;
using ProductPortal.Domain.IRepository.Urun;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Urun;

namespace ProductPortal.API.CQRS.Urun.Commands
{
    public class UpdateUrunCommandHandler : ProductPortalHandlerBase<UpdateUrunCommandHandler, UpdateUrunCommandRequest, UpdateUrunCommandResponse, IUrunRepository>
    {
        public UpdateUrunCommandHandler() : base() {}
        public override async Task<UpdateUrunCommandResponse> Handle(UpdateUrunCommandRequest request, CancellationToken cancellationToken)
        {
            var hediye = Map<UrunEntity>(request);
            hediye = UpsertBaseInfosToEntity<UrunEntity>.ForUpdate(hediye, CurrentUser,request.IsActive);
            bool result = await Repository.Update(hediye);

            if (!result)
                throw new ProductPortalException("Ürün güncellenirken bir hata oluştu!");

            return new UpdateUrunCommandResponse() { Message = "Ürün başarıyla güncellendi!" };
        }
    }
}
