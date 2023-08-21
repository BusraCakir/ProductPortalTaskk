using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Kullanici.CommandDtos;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Kullanici;
using ProductPortal.Infrastructure.Repository.Kullanici;

namespace ProductPortal.API.CQRS.Kullanici.Commands
{
    public class CreateKullaniciCommandHandler : ProductPortalHandlerBase<CreateKullaniciCommandHandler, CreateKullaniciCommandRequest, CreateKullaniciCommandResponse, KullaniciRepository>
    {
        public CreateKullaniciCommandHandler() : base() { }
        public override async Task<CreateKullaniciCommandResponse> Handle(CreateKullaniciCommandRequest request, CancellationToken cancellationToken)
        {
            KullaniciEntity entity = Map<KullaniciEntity>(request);
            entity = UpsertBaseInfosToEntity<KullaniciEntity>.ForInsert(entity, CurrentUser,false);
            bool result = await Repository.Add(entity);
            if (!result)
                throw new ProductPortalException("Kayıt Eklenirken Bir Hata Oluştu");

            return new CreateKullaniciCommandResponse() { Id = entity.Id, Message = "Kayıt Başarıyla Eklendi" };
        }
    }
}
