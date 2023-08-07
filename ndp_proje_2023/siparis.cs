using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    internal class siparis:yiyecek
    {
        // Bu metod, yeni siparişleri sipariş listesine ekler ve sipariş ekranında gösterir.
        public void yemekEkle(List<string> siparisListesi, List<string> yeniSiparisler, siparisekrani form)
        {
            foreach (string siparis in yeniSiparisler)
            {
                siparisListesi.Add(siparis);
            }

            form.siparistxtbox.Text = string.Join(Environment.NewLine, siparisListesi);
        }

        // Bu metod, seçilen siparişleri sipariş listesinden siler.
        public void yemekSil(List<string> siparisListesi, List<string> secilenler)
        {
            foreach (var secilen in secilenler)
            {
                siparisListesi.Remove(secilen);
            }
        }

        // Bu metod, sipariş listesini sipariş ekranında gösterir.
        public void SiparisleriYazdir(List<string> siparisListesi, siparisekrani form1)
        {
            form1.siparistxtbox.Text = string.Join(Environment.NewLine, siparisListesi);
        }
    }
}

/*
Yukarıdaki kod, siparis sınıfını yiyecek sınıfından türetir. Bu sınıf, siparişlerin eklenmesi, silinmesi ve listelenmesiyle ilgili işlemleri gerçekleştirir.

yemekEkle metodu, siparisListesi listesine yeniSiparisler listesini ekler ve bu siparişleri siparisekrani formunda gösterir.
yemekSil metodu, siparisListesi listesinden secilenler listesindeki siparişleri siler.
SiparisleriYazdir metodu, siparisListesi listesini siparisekrani formunda gösterir.
Bu sınıfın kullanımı, siparisekrani formunda gerçekleştirilmektedir.
*/