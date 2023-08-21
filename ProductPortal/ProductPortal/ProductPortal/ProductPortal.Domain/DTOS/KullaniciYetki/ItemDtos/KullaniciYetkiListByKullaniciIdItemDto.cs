namespace ProductPortal.Domain.Dtos.KullaniciYetki.ItemDtos
{
    public class KullaniciYetkiListItemDto
    {
        public Guid KullaniciId { get; set; }
        public string PersonelAdSoyad { get; set; }
        public List<KullaniciYetkiListDetailItemDto> YetkiList { get; set; }
    }
    public class KullaniciYetkiListDetailItemDto
    {
        public Guid KullaniciYetkiId { get; set; }
        public bool Yetkili { get; set; }
        public Guid YetkiId { get; set; }
        public string YetkiKod { get; set; }
        public string YetkiAd { get; set; }
        public string DuzenleyenPersonel { get; set; }
        public DateTime? DuzenlenmeTarihi { get; set; }
    }
}