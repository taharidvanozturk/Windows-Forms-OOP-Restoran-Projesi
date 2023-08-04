using System.Collections.Generic;

namespace ndp_proje_2023
{
    public class Depo
    {
        private Dictionary<string, int> malzemeler;

        public object Malzemeler { get; internal set; }

        public Depo()
        {
            malzemeler = new Dictionary<string, int>();
        }

        public void MalzemeEkle(string malzemeAdi, int adet)
        {
            if (malzemeler.ContainsKey(malzemeAdi))
            {
                malzemeler[malzemeAdi] += adet;
            }
            else
            {
                malzemeler.Add(malzemeAdi, adet);
            }
        }

        public bool MalzemeKontrol(string malzemeAdi, int adet)
        {
            if (malzemeler.ContainsKey(malzemeAdi) && malzemeler[malzemeAdi] >= adet)
            {
                return true;
            }
            return false;
        }

        public void MalzemeEksilt(string malzemeAdi, int adet)
        {
            if (malzemeler.ContainsKey(malzemeAdi))
            {
                malzemeler[malzemeAdi] -= adet;
            }
        }
    }
}