namespace ProductPortal.Core.CurrentUserDtos
{
    public class CurrentUserDto
    {
        public CurrentUserDto()
        {
            KullaniciId = new ValueIsExistDto<Guid>() { Value = Guid.Empty, IsExist = false };
            KullaniciAdi = new ValueIsExistDto<string>() { Value = string.Empty, IsExist = false };
            KullaniciSoyad = new ValueIsExistDto<string>() { Value = string.Empty, IsExist = false };
            Email = new ValueIsExistDto<string>() { Value = string.Empty, IsExist = false };
            YetkiKodList = new ValueIsExistDto<List<string>>() { Value = new List<string>(), IsExist = false };
        }
        public ValueIsExistDto<Guid> KullaniciId { get; set; }
        public ValueIsExistDto<string> KullaniciAdi { get; set; }
        public ValueIsExistDto<string> KullaniciSoyad { get; set; }
        public ValueIsExistDto<string> Email { get; set; }
        public ValueIsExistDto<List<string>> YetkiKodList { get; set; }
    }
}
