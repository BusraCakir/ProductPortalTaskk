using FluentValidation;
using MediatR;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Urun.QueryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Kategori.QueryDtos
{
    public class GetAllKategoriQueryRequest : IRequest<GetAllKategoriQueryResponse>
    {
        public bool GetPassives { get; set; }
        public LoadOptions LoadOptions { get; set; }
    }
    public class GetAllKategoriQueryRequestValidator : AbstractValidator<GetAllKategoriQueryRequest>
    {
        public GetAllKategoriQueryRequestValidator()
        {
        }
    }
}
