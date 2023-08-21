using FluentValidation;
using MediatR;

namespace ProductPortal.Domain.Dtos.Marka.CommandDtos
{
    public class UpdateMarkaCommandRequest : IRequest<UpdateMarkaCommandResponse>
    {
        public Guid Id { get; set; }
        public Guid ModelId { get; set; }
        public string Ad { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
    public class UpdateMarkaCommandRequestValidator : AbstractValidator<UpdateMarkaCommandRequest>
    {
        public UpdateMarkaCommandRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("<b>Marka</b> bulunamadı!");
            RuleFor(x => x.ModelId).NotEmpty().WithMessage("<b>Model</b> boş olmamalı!");
            RuleFor(x => x.Ad).NotEmpty().WithMessage("<b>Ad</b> boş olmamalı!");
        }
    }
}
