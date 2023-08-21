using FluentValidation;
using MediatR;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Urun.QueryDtos
{
    public class GetAllUrunQueryRequest : IRequest<GetAllUrunQueryResponse>
    {
        public bool GetPassives { get; set; }
        public LoadOptions LoadOptions { get; set; }
    }
    public class GetAllUrunQueryRequestValidator : AbstractValidator<GetAllUrunQueryRequest>
    {
        public GetAllUrunQueryRequestValidator()
        {
        }
    }
}
