using FluentValidation;
using MediatR;

namespace ProductPortal.Domain.Dtos.Kategori.QueryDtos
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