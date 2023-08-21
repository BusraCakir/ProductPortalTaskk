using FluentValidation;
using MediatR;
using ProductPortal.Domain.Dtos.Kullanici.QueryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Kategori.QueryDtos
{
    public class GetByIdKategoriQueryRequest : IRequest<GetByIdKategoriQueryResponse>
    {
        public Guid Id { get; set; }
    }
    public class GetByIdKategoriQueryRequestValidator : AbstractValidator<GetByIdKategoriQueryRequest>
    {
        public GetByIdKategoriQueryRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Kategori</b> bulunamadı!");
        }
    }
}
