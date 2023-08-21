using FluentValidation;
using MediatR;
using ProductPortal.Core.ProductPortalBase.HandlerBase;

namespace ProductPortal.Domain.Dtos.KullaniciYetki.QueryDtos
{
    public class GetAllKullaniciYetkiQueryRequest : IRequest<GetAllKullaniciYetkiQueryResponse>
    {
        public LoadOptions LoadOptions { get; set; }
    }
    public class GetAllKullaniciYetkiQueryRequestValidator : AbstractValidator<GetAllKullaniciYetkiQueryRequest>
    {
        public GetAllKullaniciYetkiQueryRequestValidator()
        {
        }
    }
}