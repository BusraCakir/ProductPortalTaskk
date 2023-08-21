using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Urun.CommandDtos;
using ProductPortal.Domain.IRepository.Urun;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Urun;

namespace ProductPortal.API.CQRS.Urun.Commands
{
    public class CreateUrunCommandHandler : ProductPortalHandlerBase<CreateUrunCommandHandler, CreateUrunCommandRequest, CreateUrunCommandResponse, IUrunRepository>
    {
        public CreateUrunCommandHandler() : base() {}
        public override async Task<CreateUrunCommandResponse> Handle(CreateUrunCommandRequest request, CancellationToken cancellationToken)
        {
            UrunEntity entity = Map<UrunEntity>(request);
            entity = UpsertBaseInfosToEntity<UrunEntity>.ForInsert(entity, CurrentUser, false);
            bool result = await Repository.Add(entity);
            if (!result)
                throw new ProductPortalException("Kayıt Eklenirken Bir Hata Oluştu");

            return new CreateUrunCommandResponse() { Id = entity.Id, Message = "Kayıt Başarıyla Eklendi" };
        }
    }
}
