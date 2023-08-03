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
    public partial class yeniurunformu : Form
    {
        public yeniurunformu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunAdi = urunaditxtbox.Text;
            string urunIcerigi = uruniceriktxtbox.Text;

            if (!string.IsNullOrWhiteSpace(urunAdi) && !string.IsNullOrWhiteSpace(urunIcerigi))
            {
                string yemekCesitFilePath = "C:\\Users\\taha\\source\\repos\\ndp_proje_2023\\ndp_proje_2023\\yemekcesit.txt";
                string malzemeFilePath = "C:\\Users\\taha\\source\\repos\\ndp_proje_2023\\ndp_proje_2023\\malzeme.txt";

                try
                {
                    // Ürün adını yemekcesit.txt'e ekle
                    string urunAdiSatir = "## " + urunAdi + " ##";
                    File.AppendAllText(yemekCesitFilePath, urunAdiSatir + Environment.NewLine);

                    // Ürün içeriğini malzeme.txt'ye ekle
                    File.AppendAllText(malzemeFilePath, urunIcerigi + Environment.NewLine);

                    MessageBox.Show("Ürün başarıyla eklendi!");

                    // Dosyaların içeriğini göstermek için
                    string yemekCesitIcerik = File.ReadAllText(yemekCesitFilePath);
                    string malzemeIcerik = File.ReadAllText(malzemeFilePath);

                    MessageBox.Show("yemekcesit.txt içeriği:\n\n" + yemekCesitIcerik +
                                    "\n\nmalzeme.txt içeriği:\n\n" + malzemeIcerik);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosyaya yazma hatası: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ürün adı ve ürün içeriği girin!");
            }
        }
    }
}