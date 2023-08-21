using FluentValidation;
using MediatR;
using ProductPortal.Domain.Dtos.Urun.QueryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Kullanici.QueryDtos
{
    public class GetByIdKullaniciQueryRequest : IRequest<GetByIdKullaniciQueryResponse>
    {
        public Guid Id { get; set; }
    }
    public class GetByIdKullaniciQueryRequestValidator : AbstractValidator<GetByIdKullaniciQueryRequest>
    {
        public GetByIdKullaniciQueryRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Kullanıcı</b> bulunamadı!");
        }
    }
}
