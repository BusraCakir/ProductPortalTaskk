using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Kullanici.CommandDtos;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Kullanici;
using ProductPortal.Infrastructure.Repository.Kullanici;

namespace ProductPortal.API.CQRS.Kullanici.Commands
{
    public class UpdateKullaniciCommandHandler : ProductPortalHandlerBase<UpdateKullaniciCommandHandler, UpdateKullaniciCommandRequest, UpdateKullaniciCommandResponse, KullaniciRepository>
    {
        public UpdateKullaniciCommandHandler() : base() { }
        public override async Task<UpdateKullaniciCommandResponse> Handle(UpdateKullaniciCommandRequest request, CancellationToken cancellationToken)
        {
            var marka = Map<KullaniciEntity>(request);
            marka = UpsertBaseInfosToEntity<KullaniciEntity>.ForUpdate(marka, CurrentUser, request.IsActive);
            bool result = await Repository.Update(marka);

            if (!result)
                throw new ProductPortalException("Kullanıcı güncellenirken bir hata oluştu!");

            return new UpdateKullaniciCommandResponse() { Message = "Kullanıcı başarıyla güncellendi!" };
        }
    }
}
