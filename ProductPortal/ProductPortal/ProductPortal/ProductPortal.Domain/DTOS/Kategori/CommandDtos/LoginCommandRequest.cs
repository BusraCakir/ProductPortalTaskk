using FluentValidation;
using MediatR;

namespace ProductPortal.Domain.Dtos.Kategori.CommandDtos
{
    //[ExportTsClass(OutputDir = "AngularDtos/KullaniciCommandsDto")]

    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool IsWebService { get; set; } = false;
    }

    public class LoginCommandRequestValidator : AbstractValidator<LoginCommandRequest>
    {
        public LoginCommandRequestValidator()
        {
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("<b>Kullanıcı Adı</b> bilgisi boş olmamalı!");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("<b>Şifre</b> boş olmamalı!");
        }
    }
}
