using FluentValidation;
using MediatR;
using ProductPortal.Domain.Dtos.Kategori.QueryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Marka.QueryDtos
{
    public class GetByIdMarkaQueryRequest : IRequest<GetByIdMarkaQueryResponse>
    {
        public Guid Id { get; set; }
    }
    public class GetByIdMarkaQueryRequestValidator : AbstractValidator<GetByIdMarkaQueryRequest>
    {
        public GetByIdMarkaQueryRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Marka</b> bulunamadı!");
        }
    }
}
