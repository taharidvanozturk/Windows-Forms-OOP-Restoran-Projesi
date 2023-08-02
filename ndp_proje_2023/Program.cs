using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Salata salata1 = new Salata
            {
                UrunAdi = "Yeşil Salata",
                UretimTarihi = new DateTime(2023, 7, 15),
                SonKullanmaTarihi = new DateTime(2023, 7, 20),
                KaloriGram = 50,
                StokAdet = 20,
                Fiyat = 10.99m
            };

            Salata salata2 = new Salata
            {
                UrunAdi = "Coban Salata",
                UretimTarihi = new DateTime(2023, 7, 12),
                SonKullanmaTarihi = new DateTime(2023, 7, 18),
                KaloriGram = 70,
                StokAdet = 15,
                Fiyat = 12.50m
            };

            Salata salata3 = new Salata
            {
                UrunAdi = "Sezar Salata",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 8.50m
            };

            Salata salata4 = new Salata
            {
                UrunAdi = "İstanbul Salata",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };

            Salata salata5 = new Salata
            {
                UrunAdi = "Van Salata",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };

            icecek icecek1 = new icecek
            {
                UrunAdi = "Cola",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2025, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };

            icecek icecek2 = new icecek
            {
                UrunAdi = "Fanta",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2025, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };

            icecek icecek3 = new icecek
            {
                UrunAdi = "Ayran",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };

            icecek icecek4 = new icecek
            {
                UrunAdi = "Su",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2025, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };

            icecek icecek5 = new icecek
            {
                UrunAdi = "Çay",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            meyve meyve1=new meyve
            {
                UrunAdi = "Elma",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            meyve meyve2 = new meyve
            {
                UrunAdi = "Armut",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            meyve meyve3 = new meyve
            {
                UrunAdi = "Muz",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            meyve meyve4 = new meyve
            {
                UrunAdi = "Kivi",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            meyve meyve5 = new meyve
            {
                UrunAdi = "Ejder Meyvesi",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 18),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };

            tatli tatli1 = new tatli
            {
                UrunAdi = "Kemal Paşa",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 14),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            tatli tatli2 = new tatli
            {
                UrunAdi = "Magnolya",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 14),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            tatli tatli3 = new tatli
            {
                UrunAdi = "Künefe",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 12),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            tatli tatli4 = new tatli
            {
                UrunAdi = "Waffle",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 12),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            tatli tatli5 = new tatli
            {
                UrunAdi = "Tavuk Göğsü",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 16),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            anaYemek anaYemek1 = new anaYemek
            {
                UrunAdi = "Et Sote",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 13),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            anaYemek anaYemek2 = new anaYemek
            {
                UrunAdi = "Tantuni",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 14),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            anaYemek anaYemek3 = new anaYemek
            {
                UrunAdi = "Mantı",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 13),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            anaYemek anaYemek4 = new anaYemek
            {
                UrunAdi = "Tavuklu Pilav",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 12),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };
            anaYemek anaYemek5 = new anaYemek
            {
                UrunAdi = "Etli Makarna",
                UretimTarihi = new DateTime(2023, 6, 12),
                SonKullanmaTarihi = new DateTime(2023, 6, 15),
                KaloriGram = 200,
                StokAdet = 12,
                Fiyat = 18.50m
            };





        }
    }
}
