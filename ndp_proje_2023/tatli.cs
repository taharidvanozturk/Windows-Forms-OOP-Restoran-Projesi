using System;

namespace ndp_proje_2023
{
    internal class tatli : yiyecek
    {
        public string UrunAdi { get; set; }
        public DateTime UretimTarihi { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public float KaloriGram { get; set; }
        public float StokAdet { get; set; }
        public decimal Fiyat { get; set; }
    }
}
