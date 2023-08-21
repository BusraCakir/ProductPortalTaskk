using FluentValidation;
using MediatR;

namespace ProductPortal.Domain.Dtos.KullaniciYetki.QueryDtos
{
    public class GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryRequest : IRequest<GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryResponse>
    {
        public Guid KullaniciId { get; set; }
    }

    public class GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryRequestValidator : AbstractValidator<GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryRequest>
    {
        public GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryRequestValidator()
        {
            RuleFor(x => x.KullaniciId).NotEmpty().WithMessage("<b>Kullanıcı</b> bulunamadı!");
        }
    }
}