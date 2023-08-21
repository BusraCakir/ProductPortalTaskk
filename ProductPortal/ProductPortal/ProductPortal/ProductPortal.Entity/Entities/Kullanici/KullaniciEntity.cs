using ProductPortal.Crypt.Attribute;
using ProductPortal.Entity.Core.BaseEntity;

namespace ProductPortal.Entity.Entities.Kullanici
{
    public class KullaniciEntity : BaseEntity
    {
        [NpgsqlEncrypt]
        public string Ad { get; set; }
        [NpgsqlEncrypt]
        public string Soyad { get; set; }
        public string Email { get; set; }
        [NpgsqlEncrypt]
        public string CepNumarasi { get; set; }
        [NpgsqlEncrypt]
        public string TCKimlikNo { get; set; }
        [NpgsqlEncrypt]
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsFirstLogin { get; set; }
        public DateTime? SonGirisTarihi { get; set; }
    }
}
