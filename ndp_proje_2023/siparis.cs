using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    internal class siparis
    {
        public void yemekEkle(List<string> siparisListesi, List<string> secilenler)
        {
            foreach (var secilen in secilenler)
            {
                siparisListesi.Add(secilen);
            }
            SiparisleriYazdir(siparisListesi);
        }

        public void yemekSil(List<string> siparisListesi, List<string> secilenler)
        {
            foreach (var secilen in secilenler)
            {
                siparisListesi.Remove(secilen);
            }
        }

        public void SiparisleriYazdir(List<string> siparisListesi)
        {
            siparisekrani form1 = (siparisekrani)Application.OpenForms["siparisekrani"];
            form1.siparistxtbox.Text = string.Join(Environment.NewLine, siparisListesi);
        }
    }
}
