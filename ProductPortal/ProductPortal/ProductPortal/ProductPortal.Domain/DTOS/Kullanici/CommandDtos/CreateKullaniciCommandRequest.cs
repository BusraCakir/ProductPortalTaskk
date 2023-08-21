using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Kullanici.CommandDtos
{
    public class CreateKullaniciCommandRequest : IRequest<CreateKullaniciCommandResponse>
    {
        public string KullaniciAdi { get; set; }
    }

    public class CreateKullaniciCommandRequestValidator : AbstractValidator<CreateKullaniciCommandRequest>
    {
        public CreateKullaniciCommandRequestValidator()
        {
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("<b>Kullanıcı Adı</b> bilgisi boş olmamalı!");
        }
    }
}
