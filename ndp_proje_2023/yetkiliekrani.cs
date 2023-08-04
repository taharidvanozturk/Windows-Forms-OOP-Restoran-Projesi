using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    public partial class yetkiliekrani : Form
    {
        private List<string> siparisListesi;


        public yetkiliekrani()
        {
            InitializeComponent();

        }
        public yetkiliekrani(List<string> siparisListesi) : this()
        {
            this.siparisListesi = siparisListesi;
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

            string selectedYemek = comboBox1.SelectedItem.ToString();
            yiyecek yemek = yemekler.FirstOrDefault(y => y.Ad == selectedYemek);

            if (yemek != null)
            {
                // Update the stock quantity
                yemek.yiyececekStok += miktar;

                // Update the ingredient quantities used in the selected food item
                foreach (var ingredient in yemek.Malzemeler)
                {
                    if (depo.Malzemeler.ContainsKey(ingredient.Key))
                    {
                        depo.Malzemeler[ingredient.Key] -= ingredient.Value * miktar;
                    }
                }

                // Save the updated stock and ingredient information
                SaveDepoToFile();

                // Update the display
                SiparisleriGoster();
                depoeklemeForm.UpdateDepoTextBox();
                MessageBox.Show($"{selectedYemek} başarıyla {miktar} adet eklendi.");
            }

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
