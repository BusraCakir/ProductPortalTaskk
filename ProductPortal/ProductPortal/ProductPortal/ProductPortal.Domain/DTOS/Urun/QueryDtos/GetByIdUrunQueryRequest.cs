using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Urun.QueryDtos
{
    public class GetByIdUrunQueryRequest : IRequest<GetByIdUrunQueryResponse>
    {
        public Guid Id { get; set; }
    }
    public class GetByIdUrunQueryRequestValidator : AbstractValidator<GetByIdUrunQueryRequest>
    {
        public GetByIdUrunQueryRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Ürün</b> bulunamadı!");
        }
    }
}
