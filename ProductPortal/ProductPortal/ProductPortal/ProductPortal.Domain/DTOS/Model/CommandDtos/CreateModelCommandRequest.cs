using FluentValidation;
using MediatR;
using ProductPortal.Domain.Dtos.Marka.CommandDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Model.CommandDtos
{
    public class CreateModelCommandRequest : IRequest<CreateModelCommandResponse>
    {
        public string Ad { get; set; }
        public Guid UrunId { get; set; }
    }
    public class CreateModelCommandRequestValidator : AbstractValidator<CreateModelCommandRequest>
    {
        public CreateModelCommandRequestValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("<b>Model Adı</b> bilgisi boş olmamalı!");
            RuleFor(x => x.UrunId).NotEmpty().WithMessage("<b>Ürün</b> bilgisi boş olmamalı!");
        }
    }
}
