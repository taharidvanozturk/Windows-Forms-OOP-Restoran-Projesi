using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    public partial class girisekrani : Form
    {
        private List<string> siparisListesi; // Siparişlerin tutulduğu liste
        private List<yiyecek> yemekler; // Yiyeceklerin tutulduğu liste
        private Depo depo; // Depo nesnesi

        public girisekrani()
        {
            InitializeComponent();

            // Sipariş listesi, yiyecek listesi ve depo nesnesini burada başlatın veya başka bir yerden yükleyin
            siparisListesi = new List<string>();
            yemekler = new List<yiyecek>();
            depo = new Depo();
        }

        private void resyetgirbtn_Click(object sender, EventArgs e)
        {
            // Gerekli verileri yetkiliekrani formunun yapıcısına aktarın
            var yetkiliekraniForm = new yetkiliekrani(siparisListesi, yemekler, depo);
            yetkiliekraniForm.Show();
        }

        private void siparisverbtn_Click(object sender, EventArgs e)
        {
            // Gerekli verileri siparisekrani formunun yapıcısına aktarın
            var siparisekraniForm = new siparisekrani(siparisListesi, yemekler, depo);
            siparisekraniForm.Show();
        }
    }
}

/*
Bu kod parçası, girisekrani sınıfını tanımlar. Bu sınıf, kullanıcının giriş yapabileceği bir Windows Forms uygulamasının ana formunu temsil eder.

siparisListesi: Siparişlerin tutulduğu bir liste.
yemekler: Yiyeceklerin tutulduğu bir liste.
depo: Depo nesnesi.
girisekrani sınıfı, birkaç buton olayını ve gerekli verileri diğer formlara aktarma işlemlerini gerçekleştirir.

resyetgirbtn_Click metodu, "Yetkili Ekranı" butonuna tıklanıldığında çalışır. Bu metot, yetkiliekrani formunu açar ve sipariş listesi, yiyecek listesi ve depo nesnesini bu forma aktarır.
siparisverbtn_Click metodu, "Sipariş Ekranı" butonuna tıklanıldığında çalışır. Bu metot, siparisekrani formunu açar ve sipariş listesi, yiyecek listesi ve depo nesnesini bu forma aktarır.
Bu sınıf, Windows Forms uygulamasının ana formudur ve diğer formlarla veri paylaşımını sağlar.
*/