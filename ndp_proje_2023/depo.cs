using System.Collections.Generic;

namespace ndp_proje_2023
{
    public class Depo
    {
        private Dictionary<string, int> malzemeler; // Malzemeleri depolayan sözlük

        public object Malzemeler { get; internal set; } // Malzemeleri döndüren özellik

        public Depo()
        {
            malzemeler = new Dictionary<string, int>(); // Malzemeler sözlüğünü başlat
        }

        // Malzeme ekleme methodu
        public void MalzemeEkle(string malzemeAdi, int adet)
        {
            if (malzemeler.ContainsKey(malzemeAdi)) // Malzemeler sözlüğünde malzeme adı zaten varsa
            {
                malzemeler[malzemeAdi] += adet; // Malzeme adını anahtar olarak kullanarak adeti artır
            }
            else
            {
                malzemeler.Add(malzemeAdi, adet); // Malzeme adını anahtar olarak kullanarak adeti ekle
            }
        }

        // Malzeme kontrol methodu
        public bool MalzemeKontrol(string malzemeAdi, int adet)
        {
            if (malzemeler.ContainsKey(malzemeAdi) && malzemeler[malzemeAdi] >= adet) // Malzemeler sözlüğünde malzeme adı var ve adet talebinden fazla malzeme varsa
            {
                return true; // Malzeme kontrolü başarılı
            }
            return false; // Malzeme kontrolü başarısız
        }

        // Malzeme eksiltme methodu
        public void MalzemeEksilt(string malzemeAdi, int adet)
        {
            if (malzemeler.ContainsKey(malzemeAdi)) // Malzemeler sözlüğünde malzeme adı varsa
            {
                malzemeler[malzemeAdi] -= adet; // Malzeme adını anahtar olarak kullanarak adeti azalt
            }
        }
    }
}
