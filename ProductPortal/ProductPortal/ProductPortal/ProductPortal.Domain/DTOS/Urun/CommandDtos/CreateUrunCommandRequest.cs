using FluentValidation;
using MediatR;

namespace ProductPortal.Domain.Dtos.Urun.CommandDtos
{
    public class CreateUrunCommandRequest : IRequest<CreateUrunCommandResponse>
    {
        public Guid KategoriId { get; set; }
        public string Ad { get; set; }
        public double Desi { get; set; }
        public decimal Ucret { get; set; }
        public string Aciklama { get; set; }
        public int Stok { get; set; }
    }
    public class CreateUrunCommandRequestValidator : AbstractValidator<CreateUrunCommandRequest>
    {
        public CreateUrunCommandRequestValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("<b>Ürün Adı</b> bilgisi boş olmamalı!");
            RuleFor(x => x.Ucret).NotEmpty().WithMessage("<b>Ücret</b> bilgisi boş olmamalı!");
            RuleFor(x => x.KategoriId).NotEmpty().WithMessage("<b>Kategori</b> bilgisi boş olmamalı!");
        }
    }
}
