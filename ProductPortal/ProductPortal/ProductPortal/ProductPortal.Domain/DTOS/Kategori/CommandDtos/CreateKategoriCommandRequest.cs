using FluentValidation;
using MediatR;
using ProductPortal.Domain.Dtos.Urun.CommandDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Kategori.CommandDtos
{
    public class CreateKategoriCommandRequest : IRequest<CreateKategoriCommandResponse>
    {
        public string Ad { get; set; }
    }
    public class CreateKategoriCommandRequestValidator : AbstractValidator<CreateKategoriCommandRequest>
    {
        public CreateKategoriCommandRequestValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("<b>Kategori Adı</b> bilgisi boş olmamalı!");
        }
    }
}
