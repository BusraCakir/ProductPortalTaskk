using FluentValidation;
using MediatR;
using ProductPortal.Domain.Dtos.Marka.QueryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Model.QueryDtos
{
    public class GetByIdModelQueryRequest : IRequest<GetByIdModelQueryResponse>
    {
        public Guid Id { get; set; }
    }
    public class GetByIdModelQueryRequestValidator : AbstractValidator<GetByIdModelQueryRequest>
    {
        public GetByIdModelQueryRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Model</b> bulunamadı!");
        }
    }
}
