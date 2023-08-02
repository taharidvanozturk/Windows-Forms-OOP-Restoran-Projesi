using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ndp_proje_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private siparis siparisInstance = new siparis();
        private List<string> siparisListesi = new List<string>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();

        


        private void yesilsalatabtn_Click(object sender, EventArgs e)
        {
            string siparis = yesilsalatabtn.Text; // Örnek amaçlı sabit bir sipariş


            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void cobansalatabtn_Click(object sender, EventArgs e)
        {
            string siparis = cobansalatabtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void sezarsalatabtn_Click(object sender, EventArgs e)
        {
            string siparis = sezarsalatabtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void istsalbtn_Click(object sender, EventArgs e)
        {
            string siparis = istsalbtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void vansalatabtn_Click(object sender, EventArgs e)
        {
            string siparis = vansalatabtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void etsotebtn_Click(object sender, EventArgs e)
        {
            string siparis = etsotebtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void tantunibtn_Click(object sender, EventArgs e)
        {
            string siparis = tantunibtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void mantibtn_Click(object sender, EventArgs e)
        {
            string siparis = mantibtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void tvkplvbtn_Click(object sender, EventArgs e)
        {
            string siparis = tvkplvbtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void etmkrnbtn_Click(object sender, EventArgs e)
        {
            string siparis = etmkrnbtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void colabtn_Click(object sender, EventArgs e)
        {
            string siparis = colabtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void fantabtn_Click(object sender, EventArgs e)
        {
            string siparis = fantabtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void ayranbtn_Click(object sender, EventArgs e)
        {
            string siparis = ayranbtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void subtn_Click(object sender, EventArgs e)
        {
            string siparis = subtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void caybtn_Click(object sender, EventArgs e)
        {
            string siparis = caybtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void elmabtn_Click(object sender, EventArgs e)
        {
            string siparis = elmabtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void armutbtn_Click(object sender, EventArgs e)
        {
            string siparis = armutbtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void muzbtn_Click(object sender, EventArgs e)
        {
            string siparis = muzbtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void kivibtn_Click(object sender, EventArgs e)
        {
            string siparis = kivibtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void ejdermeybtn_Click(object sender, EventArgs e)
        {
            string siparis = ejdermeybtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void KemalPasabtn_Click(object sender, EventArgs e)
        {
            string siparis = KemalPasabtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void magnolyabtn_Click(object sender, EventArgs e)
        {
            string siparis = magnolyabtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void kunefebtn_Click(object sender, EventArgs e)
        {
            string siparis = kunefebtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void wafflebtn_Click(object sender, EventArgs e)
        {
            string siparis = wafflebtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }

        private void tvkgsbtn_Click(object sender, EventArgs e)
        {
            string siparis = tvkgsbtn.Text; // Örnek amaçlı sabit bir sipariş

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis });
        }


        private void silButton_Click(object sender, EventArgs e)
        {
            if (siparisListesi.Count == 0)
            {
                MessageBox.Show("Sipariş listesi boş.");
                return;
            }

            GroupBox groupBox = new GroupBox // Move the declaration here
            {
                Text = "Silinecek Ürünleri Seçin",
                Dock = DockStyle.Fill
            };

            using (var silForm = new Form())
            {
                foreach (var siparis in siparisListesi)
                {
                    var checkBox = new CheckBox
                    {
                        Text = siparis,
                        Dock = DockStyle.Top
                    };
                    groupBox.Controls.Add(checkBox);
                    checkBoxes.Add(checkBox);
                }

                var silButton = new Button
                {
                    Text = "Seçilen Ürünleri Sil",
                    Dock = DockStyle.Bottom
                };
                silButton.Click += (s, args) =>
                {
                    var secilenler = checkBoxes.Where(cb => cb.Checked).Select(cb => cb.Text).ToList();
                    siparisInstance.yemekSil(siparisListesi, secilenler);

                    siparistxtbox.Text = string.Join(Environment.NewLine, siparisListesi);
                    silForm.Close();
                };

                var panel = new Panel
                {
                    Dock = DockStyle.Fill
                };
                panel.Controls.Add(groupBox);
                panel.Controls.Add(silButton);

                silForm.Text = "Sipariş Sil";
                silForm.ClientSize = new Size(300, 200);
                silForm.Controls.Add(panel);
                silForm.ShowDialog();
            }
        }

        private void siparisonaybtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(Environment.NewLine,"Siparişiniz:")+"\r\n"+string.Join(Environment.NewLine, siparisListesi));
        }
    }
}
