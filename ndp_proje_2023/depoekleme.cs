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
    public partial class depoekleme : Form
    {
        public depoekleme()
        {
            InitializeComponent();
        }

        private void depoeklebtn_Click(object sender, EventArgs e)
        {
            string urunAdi = textBox1.Text;
            string adetStr = textBox2.Text;

            if (!string.IsNullOrWhiteSpace(urunAdi) && int.TryParse(adetStr, out int adet))
            {
                try
                {
                    // Dosyaya ekleme işlemi
                    using (StreamWriter writer = new StreamWriter("depo.txt", true))
                    {
                        writer.WriteLine($"{urunAdi} --- {adet}");
                    }

                    MessageBox.Show("Ürün depoya eklendi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosyaya yazma hatası: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ürün adı ve adet girin!");
            }
        }

    }
}

