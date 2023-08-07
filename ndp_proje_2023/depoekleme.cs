using System;
using System.IO;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    public partial class depoekleme : Form
    {
        public depoekleme()
        {
            InitializeComponent();
        }

        private void depoeklebtn_Click(object sender, EventArgs e)
        {
            string urunAdi = textBox1.Text; // TextBox1'deki metni al ve urunAdi değişkenine ata
            string adetStr = textBox2.Text; // TextBox2'deki metni al ve adetStr değişkenine ata

            if (!string.IsNullOrWhiteSpace(urunAdi) && int.TryParse(adetStr, out int adet))
            {
                try
                {
                    // Dosyaya ekleme işlemi
                    using (StreamWriter writer = new StreamWriter("depo.txt", true)) // "depo.txt" dosyasına yazma işlemi için StreamWriter kullan
                    {
                        writer.WriteLine($"{urunAdi} --- {adet}"); // Dosyaya ürün adı ve adeti yaz
                    }

                    MessageBox.Show("Ürün depoya eklendi!"); // Ekleme işlemi başarılıysa mesaj kutusu göster
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosyaya yazma hatası: " + ex.Message); // Yazma hatası durumunda hata mesajı göster
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ürün adı ve adet girin!"); // Geçerli bir ürün adı ve adet girilmediğinde hata mesajı göster
            }
        }

        private void depoekleme_Load(object sender, EventArgs e)
        {

        }
    }
}
