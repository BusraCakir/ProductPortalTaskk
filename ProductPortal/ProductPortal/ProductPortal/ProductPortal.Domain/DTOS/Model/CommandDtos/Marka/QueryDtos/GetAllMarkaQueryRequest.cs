using FluentValidation;
using MediatR;
using ProductPortal.Core.ProductPortalBase.HandlerBase;

namespace ProductPortal.Domain.Dtos.Marka.QueryDtos
{
    public class GetAllMarkaQueryRequest : IRequest<GetAllMarkaQueryResponse>
    {
        public bool GetPassives { get; set; }
        public LoadOptions LoadOptions { get; set; }
    }
    public class GetAllMarkaQueryRequestValidator : AbstractValidator<GetAllMarkaQueryRequest>
    {
        public GetAllMarkaQueryRequestValidator()
        {
        }
    }
}
