using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    internal class siparis:yiyecek
    {
        public void yemekEkle(List<string> siparisListesi, List<string> yeniSiparisler, siparisekrani form)
        {
            foreach (var yeniSiparis in yeniSiparisler)
            {
                if (!siparisListesi.Contains(yeniSiparis))
                {
                    siparisListesi.Add(yeniSiparis);
                    form.siparistxtbox.Text = string.Join(Environment.NewLine, siparisListesi);
                }
            }
        }

        public void yemekSil(List<string> siparisListesi, List<string> secilenler)
        {
            foreach (var secilen in secilenler)
            {
                siparisListesi.Remove(secilen);
            }
        }

        public void SiparisleriYazdir(List<string> siparisListesi, siparisekrani form1)
        {
            form1.siparistxtbox.Text = string.Join(Environment.NewLine, siparisListesi);
        }
    }
}
