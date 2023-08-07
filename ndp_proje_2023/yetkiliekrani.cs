using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    public partial class yetkiliekrani : Form
    {
        // Sipariş listesi, yiyecekler ve depo bilgileri için alanlar
        public readonly List<string> siparisListesi;
        public readonly List<yiyecek> yemekler;
        public Depo depo; 
        public Dictionary<string, int> Malzemeler { get; set; }

        // Yetkili ekranı sınıfının kurucu methodu
        public yetkiliekrani(List<string> siparisListesi, List<yiyecek> yemekler, Depo depo)
        {
            InitializeComponent(); // İlk olarak bileşenleri başlatın
            this.siparisListesi = siparisListesi;
            this.yemekler = yemekler;
            this.depo = depo; // Depo alanını başlatın
        }

        // Yetkili ekranı yükleme methodu
        public void yetkiliekrani_Load(object sender, EventArgs e)
        {
            SiparisleriGoster();
        }

        // Siparişleri gösterme methodu
        public void SiparisleriGoster()
        {
            guncelsiparislertxtbox.Text = string.Join(Environment.NewLine, siparisListesi);
        }

        // Stok ekleme butonuna tıklanma methodu
        public void stokeklebtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir yemek seçin.");
                return;
            }

            if (!int.TryParse(textBoxMiktar.Text, out int miktar) || miktar <= 0)
            {
                MessageBox.Show("Geçerli bir miktar girin.");
                return;
            }

            string selectedYemek = comboBox1.SelectedItem.ToString();

        }

        // Stok silme butonuna tıklanma methodu
        public void stoksilbtn_Click(object sender, EventArgs e)
        {

        }

        // Stokları görüntüleme butonuna tıklanma methodu
        public void stokgorbtn_Click(object sender, EventArgs e)
        {

        }

        // Yeni ürün formunu açma butonuna tıklanma methodu
        public void button1_Click(object sender, EventArgs e)
        {
            var yeniurunformu = new yeniurunformu();
            yeniurunformu.Show();
        }

        // Depo ekleme formunu açma butonuna tıklanma methodu
        public void depoeklebtn_Click(object sender, EventArgs e)
        {
            var depoekleme = new depoekleme();
            depoekleme.Show();
        }

        // Depoyu görüntüleme butonuna tıklanma methodu
        public void depogorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Dosya okuma ve içeriği depoTextBox'a yazma işlemi
                using (StreamReader reader = new StreamReader("depo.txt"))
                {
                    depotxtbox.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
            }
        }

        public void guncelsiparislertxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        // Geri git butonuna tıklayıp yetkili ekranından sipariş ekranına dönmek için metod
        private void gerigitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
