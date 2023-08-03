using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_2023
{
    public class Depo
    {
        private Dictionary<string, int> malzemeler;

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