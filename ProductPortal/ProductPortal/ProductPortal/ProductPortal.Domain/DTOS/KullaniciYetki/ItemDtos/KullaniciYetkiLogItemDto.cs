using System;

namespace KfzBuyukFilo.Domain.Dtos.ItemDtos
{
    public class KullaniciYetkiLogItemDto
    {
        public string Islem { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public string IslemYapanPersonel { get; set; }
    }
}