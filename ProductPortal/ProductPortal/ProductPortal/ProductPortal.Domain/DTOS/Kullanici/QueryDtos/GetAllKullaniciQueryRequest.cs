using FluentValidation;
using MediatR;
using ProductPortal.Core.ProductPortalBase.HandlerBase;

namespace ProductPortal.Domain.Dtos.Kullanici.QueryDtos
{
    public class GetAllKullaniciQueryRequest : IRequest<GetAllKullaniciQueryResponse>
    {
        public bool GetPassives { get; set; }
        public LoadOptions LoadOptions { get; set; }
    }

    public class GetAllKullaniciQueryRequestValidator : AbstractValidator<GetAllKullaniciQueryRequest>
    {
    }
}
