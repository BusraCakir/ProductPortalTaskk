using FluentValidation;
using MediatR;

namespace ProductPortal.Domain.Dtos.Kullanici.CommandDtos
{
    public class UpdateKullaniciCommandRequest : IRequest<UpdateKullaniciCommandResponse>
    {
        public Guid KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string CepNumarasi { get; set; }
        public string TCKimlikNo { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }

    public class UpdateKullaniciCommandRequestValidator : AbstractValidator<UpdateKullaniciCommandRequest>
    {
        public UpdateKullaniciCommandRequestValidator()
        {
            RuleFor(x => x.KullaniciId).NotEmpty().WithMessage("<b>Kullanıcı</b> bulunamadı!");
            RuleFor(x => x.Ad).MaximumLength(25).WithMessage("<b>Kullanıcı Adı</b> maksimum <b>50 karakter</b> olabilir!").NotEmpty().WithMessage("Kullanıcı adı boş olamaz!");
            RuleFor(x => x.Soyadi).MaximumLength(25).WithMessage("<b>Kullanıcı Soyadı</b> maksimum <b>50 karakter</b> olabilir!").NotEmpty().WithMessage("Kullanıcı adı boş olamaz!");
            RuleFor(x => x.TCKimlikNo).MaximumLength(11).WithMessage("<b>T.C. Kimlik Numarası</b> maksimum <b>11 karakter</b> olabilir!").NotEmpty().WithMessage("Kullanıcı adı boş olamaz!");
            RuleFor(x => x.Password).MaximumLength(15).MinimumLength(8).WithMessage("<b>Password </b> maksimum <b>15 karakter</b> minimum <b>8 karakter</b> olabilir!").NotEmpty().WithMessage("Kullanıcı adı boş olamaz!");
        }
    }
}
