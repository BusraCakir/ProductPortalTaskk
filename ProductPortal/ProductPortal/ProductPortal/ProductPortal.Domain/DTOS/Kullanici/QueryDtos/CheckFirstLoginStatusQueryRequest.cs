using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Kullanici.QueryDtos
{
    public class CheckFirstLoginStatusQueryRequest : IRequest<CheckFirstLoginStatusQueryResponse>
    {
        public Guid Id { get; set; }
    }
    public class CheckFirstLoginStatusQueryRequestValidator : AbstractValidator<CheckFirstLoginStatusQueryRequest>
    {
        public CheckFirstLoginStatusQueryRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Giriş Bilgisi</b> bulunamadı!");
        }
    }
}
