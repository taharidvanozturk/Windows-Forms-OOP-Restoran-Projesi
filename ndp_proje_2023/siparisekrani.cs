using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    public partial class siparisekrani : Form
    {
        private List<string> siparisListesi;
        private List<yiyecek> yemekler;
        private Depo depo;
        private siparis siparisInstance = new siparis();
        public List<CheckBox> checkBoxes = new List<CheckBox>();

        public siparisekrani()
        {
            InitializeComponent();
            siparisListesi = new List<string>();
            yemekler = new List<yiyecek>();
            depo = new Depo();
        }


        public siparisekrani(List<string> siparisListesi, List<yiyecek> yemekler, Depo depo) : this()
        {
            this.siparisListesi = siparisListesi;
            this.yemekler = yemekler;
            this.depo = depo;
        }

        public class FoodPriceCalculator
        {
            public Dictionary<string, decimal> ingredientPrices;
            public List<yiyecek> yemekler;


            public FoodPriceCalculator(Dictionary<string, decimal> ingredientPrices, List<yiyecek> yemekler)
            {
                this.ingredientPrices = ingredientPrices;
                this.yemekler = yemekler;

            }

            public decimal CalculateSellingPrice(yiyecek foodItem)
            {
                decimal totalPrice = 0;

                foreach (var ingredient in foodItem.Malzemeler)
                {
                    if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                    {
                        totalPrice += price * ingredient.Value;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Ingredient price not found for: {ingredient.Key}");
                    }
                }

                // Assuming KDV is a percentage (e.g., 8%)
                decimal kdvRate = Convert.ToDecimal(foodItem.yiyecekKDVOrani);
                decimal sellingPrice = totalPrice * (1 + kdvRate / 100);

                return sellingPrice;
            }

            public decimal CalculateSellingPrice(List<string> siparisListesi)
            {
                decimal totalPrice = 0;

                foreach (var siparis in siparisListesi)
                {
                    yiyecek yemek = yemekler.FirstOrDefault(y => y.Ad == siparis);
                    if (yemek != null)
                    {
                        totalPrice += CalculateSellingPrice(yemek);
                    }
                }

                return totalPrice;
            }
        }

        private Dictionary<string, decimal> ingredientPrices = new Dictionary<string, decimal>();

        private void YemekleriYukle()
        {
            try
            {
                string json = File.ReadAllText("yemekler.json");
                List<yiyecek> yemekList = JsonSerializer.Deserialize<List<yiyecek>>(json);

                // Populate the ingredientPrices dictionary with ingredient names and their prices
                foreach (var yemek in yemekList)
                {
                    foreach (var ingredient in yemek.Malzemeler)
                    {
                        if (!ingredientPrices.ContainsKey(ingredient.Key))
                        {
                            ingredientPrices.Add(ingredient.Key, ingredient.Value);
                        }
                    }
                }

                List<yiyecek> yemekAdList = new List<yiyecek>();
                Random random = new Random();

                // Create an instance of FoodPriceCalculator
                FoodPriceCalculator priceCalculator = new FoodPriceCalculator(ingredientPrices, yemekler);

                foreach (var yemek in yemekList)
                {
                    string yemekAd = yemek.Ad;
                    if (yemekAdList.Any(y => y.Ad == yemekAd))
                    {
                        yemekAd += " --- " + random.Next(1000, 10000);
                    }
                    yemek.Ad = yemekAd;
                    yemekAdList.Add(yemek);

                    // Calculate the selling price of the yemek and display it
                    decimal sellingPrice = priceCalculator.CalculateSellingPrice(yemek); // Use the existing priceCalculator here
                    Console.WriteLine($"Yemek: {yemek.Ad}, Satış Fiyatı: {sellingPrice:F2}");
                }

                yemekler = yemekAdList;

                yemekler = yemekAdList;

                yemekler = yemekAdList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yemekler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }




        private void yesilsalatabtn_Click(object sender, EventArgs e)
        {
            string siparis = yesilsalatabtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this); 
            
        }
        private void cobansalatabtn_Click(object sender, EventArgs e)
        {
            string siparis = cobansalatabtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void sezarsalatabtn_Click(object sender, EventArgs e)
        {
            string siparis = sezarsalatabtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void istsalbtn_Click(object sender, EventArgs e)
        {
            string siparis = istsalbtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void vansalatabtn_Click(object sender, EventArgs e)
        {
            string siparis = vansalatabtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void etsotebtn_Click(object sender, EventArgs e)
        {
            string siparis = etsotebtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void tantunibtn_Click(object sender, EventArgs e)
        {
            string siparis = tantunibtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void mantibtn_Click(object sender, EventArgs e)
        {
            string siparis = mantibtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void tvkplvbtn_Click(object sender, EventArgs e)
        {
            string siparis = tvkplvbtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void etmkrnbtn_Click(object sender, EventArgs e)
        {
            string siparis = etmkrnbtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void colabtn_Click(object sender, EventArgs e)
        {
            string siparis = colabtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void fantabtn_Click(object sender, EventArgs e)
        {
            string siparis = fantabtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void ayranbtn_Click(object sender, EventArgs e)
        {
            string siparis = ayranbtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void subtn_Click(object sender, EventArgs e)
        {
            string siparis = subtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void caybtn_Click(object sender, EventArgs e)
        {
            string siparis = caybtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void elmabtn_Click(object sender, EventArgs e)
        {
            string siparis = elmabtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void armutbtn_Click(object sender, EventArgs e)
        {
            string siparis = armutbtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void muzbtn_Click(object sender, EventArgs e)
        {
            string siparis = muzbtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void kivibtn_Click(object sender, EventArgs e)
        {
            string siparis = kivibtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void ejdermeybtn_Click(object sender, EventArgs e)
        {
            string siparis = ejdermeybtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void KemalPasabtn_Click(object sender, EventArgs e)
        {
            string siparis = KemalPasabtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void magnolyabtn_Click(object sender, EventArgs e)
        {
            string siparis = magnolyabtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void kunefebtn_Click(object sender, EventArgs e)
        {
            string siparis = kunefebtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void wafflebtn_Click(object sender, EventArgs e)
        {
            string siparis = wafflebtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
        }

        private void tvkgsbtn_Click(object sender, EventArgs e)
        {
            string siparis = tvkgsbtn.Text;

            siparisInstance.yemekEkle(siparisListesi, new List<string> { siparis }, this);
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

        public void siparisonaybtn_Click(object sender, EventArgs e)
        {
            YemekleriYukle();
            MessageBox.Show("Siparişiniz:\r\n" + string.Join(Environment.NewLine, siparisListesi));

            // Calculate the total price using the CalculateTotalPrice method
            decimal totalPrice = CalculateTotalPrice();

            // Calculate the selling price of selectedFoodItem using the FoodPriceCalculator
            FoodPriceCalculator priceCalculator = new FoodPriceCalculator(ingredientPrices, yemekler);
            decimal sellingPrice = priceCalculator.CalculateSellingPrice(siparisListesi);

            string totalPriceText = totalPrice.ToString("F2");
            UpdateFiyatLabel(totalPriceText);

            // Pass the necessary parameters to yetkiliekrani constructor
            yetkiliekrani yetkiliekraniForm = new yetkiliekrani(siparisListesi, yemekler, depo);
            yetkiliekraniForm.Show();
        }

        private void siparisekrani_Load(object sender, EventArgs e)
        {

        }
        public void UpdateFiyatLabel(string fiyat)
        {
            lblFiyat.Text = fiyat;
        }
        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var siparis in siparisListesi)
            {
                yiyecek yemek = yemekler.FirstOrDefault(y => y.Ad == siparis);
                if (yemek != null)
                {
                    totalPrice += yemek.yiyececekFiyat;
                }
            }
            return totalPrice;
        }

    }
}
