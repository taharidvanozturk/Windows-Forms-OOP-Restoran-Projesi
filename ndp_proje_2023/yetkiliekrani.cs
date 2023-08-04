using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    public partial class yetkiliekrani : Form
    {
        private List<string> siparisListesi;
        private List<yiyecek> yemekler;
        private Depo depo; // Add this field
        public Dictionary<string, int> Malzemeler { get; set; }


        public yetkiliekrani()
        {
            InitializeComponent();
        }

        // Modify the constructor to accept siparisListesi, yemekler, and depo
        public yetkiliekrani(List<string> siparisListesi, List<yiyecek> yemekler, Depo depo) : this()
        {
            this.siparisListesi = siparisListesi;
            this.yemekler = yemekler;
            this.depo = depo; // Initialize the depo field
            SiparisleriGoster();
        }


        private void SiparisleriGoster()
        {
            guncelsiparislertxtbox.Text = string.Join(Environment.NewLine, siparisListesi);
        }
        private void yetkiliekrani_Load(object sender, EventArgs e)
        {

        }

        private void stokeklebtn_Click(object sender, EventArgs e)
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


        private void stoksilbtn_Click(object sender, EventArgs e)
        {

        }

        private void stokgorbtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yeniurunformu = new yeniurunformu();
            yeniurunformu.Show();
        }

        private void depoeklebtn_Click(object sender, EventArgs e)
        {
            var depoekleme = new depoekleme();
            depoekleme.Show();
        }

        private void depogorbtn_Click(object sender, EventArgs e)
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

        private void guncelsiparislertxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
