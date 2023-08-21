using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.KullaniciYetki.CommandDtos;
using ProductPortal.Domain.IRepository.KullaniciYetki;

namespace ProductPortal.API.CQRS.KullaniciYetki.Commands
{
    public class UpsertKullaniciYetkiCommandHandler : ProductPortalHandlerBase<UpsertKullaniciYetkiCommandHandler, UpsertKullaniciYetkiCommandRequest, UpsertKullaniciYetkiCommandResponse, IKullaniciYetkiRepository>
    {
        public UpsertKullaniciYetkiCommandHandler() : base() { }
        public override async Task<UpsertKullaniciYetkiCommandResponse> Handle(UpsertKullaniciYetkiCommandRequest request, CancellationToken cancellationToken)
        {
            await Repository.UpsertKullaniciYetki(request.UpsertList);
            return new UpsertKullaniciYetkiCommandResponse() { Id = Guid.NewGuid(), Message = "Kayıt Başarıyla Eklendi" };

        }
    }
}
