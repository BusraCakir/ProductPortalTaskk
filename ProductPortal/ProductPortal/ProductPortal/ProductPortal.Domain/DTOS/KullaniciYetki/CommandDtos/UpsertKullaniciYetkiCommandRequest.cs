using FluentValidation;
using MediatR;
using ProductPortal.Domain.Dtos.KullaniciYetki.ItemDtos;

namespace ProductPortal.Domain.Dtos.KullaniciYetki.CommandDtos
{
    public class UpsertKullaniciYetkiCommandRequest : IRequest<UpsertKullaniciYetkiCommandResponse>
    {
        public List<KullaniciYetkiListItemDto> UpsertList { get; set; }
    }
    public class UpsertKullaniciYetkiCommandRequestValidator : AbstractValidator<UpsertKullaniciYetkiCommandRequest>
    {
        public UpsertKullaniciYetkiCommandRequestValidator()
        {
            RuleFor(x => x.UpsertList).NotEmpty().WithMessage("<b>Yetki</b> listesi boþ olmamalý!");
        }
    }
}