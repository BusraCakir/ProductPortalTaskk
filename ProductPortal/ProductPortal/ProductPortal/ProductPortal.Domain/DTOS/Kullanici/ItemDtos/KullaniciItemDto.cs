namespace ProductPortal.Domain.Dtos.Kullanici.ItemDtos
{
    public class KullaniciItemDto
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CepNumarasi { get; set; }
        public string TCKimlikNo { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUser { get; set; }
        public bool IsActive { get; set; }
    }
}
