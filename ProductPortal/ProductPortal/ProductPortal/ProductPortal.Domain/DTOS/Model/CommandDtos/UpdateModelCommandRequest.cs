using FluentValidation;
using MediatR;

namespace ProductPortal.Domain.Dtos.Model.CommandDtos
{
    public class UpdateModelCommandRequest : IRequest<UpdateModelCommandResponse>
    {
        public Guid Id { get; set; }
        public Guid UrunId { get; set; }
        public string Ad { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
    public class UpdateModelCommandRequestValidator : AbstractValidator<UpdateModelCommandRequest>
    {
        public UpdateModelCommandRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Marka</b> bulunamadı!");
            RuleFor(x => x.UrunId).NotEmpty().WithMessage("<b>Ürün</b> boş olmamalı!");
            RuleFor(x => x.Ad).NotEmpty().WithMessage("<b>Ad</b> boş olmamalı!");
        }
    }
}
