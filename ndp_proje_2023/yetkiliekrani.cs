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



        public yetkiliekrani(List<string> siparisListesi, List<yiyecek> yemekler, Depo depo)
        {
            InitializeComponent(); // Initialize the components first
            this.siparisListesi = siparisListesi;
            this.yemekler = yemekler;
            this.depo = depo; // Initialize the depo field
        }
        public void yetkiliekrani_Load(object sender, EventArgs e)
        {
            SiparisleriGoster();
        }

        public void SiparisleriGoster()
        {
            guncelsiparislertxtbox.Text = string.Join(Environment.NewLine, siparisListesi);
        }

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


        public void stoksilbtn_Click(object sender, EventArgs e)
        {

        }

        public void stokgorbtn_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            var yeniurunformu = new yeniurunformu();
            yeniurunformu.Show();
        }

        public void depoeklebtn_Click(object sender, EventArgs e)
        {
            var depoekleme = new depoekleme();
            depoekleme.Show();
        }

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

        private void gerigitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
