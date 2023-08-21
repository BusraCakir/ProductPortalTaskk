using FluentValidation;
using MediatR;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Marka.QueryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Model.QueryDtos
{
    public class GetAllModelQueryRequest : IRequest<GetAllModelQueryResponse>
    {
        public bool GetPassives { get; set; }
        public LoadOptions LoadOptions { get; set; }
    }
    public class GetAllModelQueryRequestValidator : AbstractValidator<GetAllModelQueryRequest>
    {
        public GetAllModelQueryRequestValidator()
        {
        }
    }
}
