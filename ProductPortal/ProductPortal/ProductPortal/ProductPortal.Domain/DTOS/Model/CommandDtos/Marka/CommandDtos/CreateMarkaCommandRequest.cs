using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Marka.CommandDtos
{
    public class CreateMarkaCommandRequest : IRequest<CreateMarkaCommandResponse>
    {
        public string Ad { get; set; }
        public Guid ModelId { get; set; }
    }
    public class CreateMarkaCommandRequestValidator : AbstractValidator<CreateMarkaCommandRequest>
    {
        public CreateMarkaCommandRequestValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("<b>Marka Adı</b> bilgisi boş olmamalı!");
            RuleFor(x => x.ModelId).NotEmpty().WithMessage("<b>Model</b> bilgisi boş olmamalı!");
        }
    }
}
