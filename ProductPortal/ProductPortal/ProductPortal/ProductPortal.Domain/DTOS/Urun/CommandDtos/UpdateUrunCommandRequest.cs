using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Dtos.Urun.CommandDtos
{
    public class UpdateUrunCommandRequest : IRequest<UpdateUrunCommandResponse>
    {
        public Guid Id { get; set; }
        public Guid KategoriId { get; set; }
        public string Ad { get; set; }
        public decimal Ucret { get; set; }
        public string Aciklama { get; set; }
        public int Stok { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
    public class UpdateUrunCommandRequestValidator : AbstractValidator<UpdateUrunCommandRequest>
    {
        public UpdateUrunCommandRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Hediye</b> bulunamadı!");
            RuleFor(x => x.KategoriId).NotEmpty().WithMessage("<b>Kategori</b> boş olmamalı!");
            RuleFor(x => x.Ad).NotEmpty().WithMessage("<b>Ad</b> boş olmamalı!");
        }
    }
}
