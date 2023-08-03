using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;

namespace ndp_proje_2023
{
    public partial class siparisekrani : Form
    {


        public Depo depo;
        public siparisekrani()
        {
            InitializeComponent();
            depo = new Depo();
            DepoVerileriniDoldur();
            YemekleriYukle();
        }


        private siparis siparisInstance = new siparis();
        private List<string> siparisListesi = new List<string>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private void DepoVerileriniDoldur()
        {
            // depo.txt dosyasındaki malzeme verilerini depo nesnesine ekle
            // Dosya formatı: malzeme --- adet
            string[] depoVerileri = System.IO.File.ReadAllLines("depo.txt");
            foreach (string depoVeri in depoVerileri)
            {
                string[] veriParcalari = depoVeri.Split(new string[] { " --- " }, StringSplitOptions.None);
                if (veriParcalari.Length == 2 && int.TryParse(veriParcalari[1], out int adet))
                {
                    depo.MalzemeEkle(veriParcalari[0], adet);
                }
            }

        }



        private List<yiyecek> yemekler; // Change the type to List<yiyecek>

        private void YemekleriYukle()
        {
            try
            {
                string json = File.ReadAllText("yemekler.json");
                List<yiyecek> yemekList = JsonSerializer.Deserialize<List<yiyecek>>(json);

                List<yiyecek> yemekAdList = new List<yiyecek>(); // Change the type to List<yiyecek>
                Random random = new Random();

                foreach (var yemek in yemekList)
                {
                    string yemekAd = yemek.Ad;
                    if (yemekAdList.Any(y => y.Ad == yemekAd)) // Check if the yemekAd already exists in the list
                    {
                        yemekAd += " --- " + random.Next(1000, 10000); // Add random quantity
                    }
                    yemek.Ad = yemekAd; // Update the Ad property of the yiyecek object
                    yemekAdList.Add(yemek);
                }

                yemekler = yemekAdList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yemekler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }




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
            MessageBox.Show(string.Join(Environment.NewLine, "Siparişiniz:") + "\r\n" + string.Join(Environment.NewLine, siparisListesi));
            
        }
    }
}
