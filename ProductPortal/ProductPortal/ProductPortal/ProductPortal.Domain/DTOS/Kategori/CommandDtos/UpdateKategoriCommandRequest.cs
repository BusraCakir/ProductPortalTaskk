using FluentValidation;
using MediatR;
using ProductPortal.Domain.Dtos.Urun.CommandDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Kategori.CommandDtos
{
    public class UpdateKategoriCommandRequest : IRequest<UpdateKategoriCommandResponse>
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
    public class UpdateKategoriCommandRequestValidator : AbstractValidator<UpdateKategoriCommandRequest>
    {
        public UpdateKategoriCommandRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Kategori</b> bulunamadı!");
            RuleFor(x => x.Ad).NotEmpty().WithMessage("<b>Kategori Ad</b> boş olmamalı!");
        }
    }
}
