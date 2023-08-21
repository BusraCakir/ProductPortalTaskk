using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Urun.CommandDtos
{
    public class DeleteUrunCommandRequest : IRequest<DeleteUrunCommandResponse>
    {
        public List<Guid> IdList { get; set; }
    }

    public class DeleteUrunCommandRequestValidator : AbstractValidator<DeleteUrunCommandRequest>
    {
        public DeleteUrunCommandRequestValidator()
        {
            RuleFor(x => x.IdList).NotEmpty().WithMessage("<b>Ürün</b> bulunamadı!");
        }
    }
}
