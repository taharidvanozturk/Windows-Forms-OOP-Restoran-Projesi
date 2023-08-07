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
        private List<string> siparisListesi; // Sipariş listesini tutan liste
        private List<yiyecek> yemekler; // Yiyeceklerin tutulduğu liste
        private Depo depo; // Depo nesnesi
        private siparis siparisInstance = new siparis(); // Siparis sınıfı örneği
        public List<CheckBox> checkBoxes = new List<CheckBox>(); // CheckBox nesnesi

        public siparisekrani() 
        {
            InitializeComponent();
            siparisListesi = new List<string>();
            yemekler = new List<yiyecek>();
            depo = new Depo();
        }

        // Sipariş listesi, yiyecek listesi ve depo nesnesini burada başlatın veya başka bir yerden yükleyin
        public siparisekrani(List<string> siparisListesi, List<yiyecek> yemekler, Depo depo) : this()
        {
            this.siparisListesi = siparisListesi;
            this.yemekler = yemekler;
            this.depo = depo;
        }

        public class FoodPriceCalculator
        {
            public Dictionary<string, decimal> ingredientPrices; // Malzeme fiyatlarını tutan sözlük
            public List<yiyecek> yemekler; // Yiyecekleri tutan liste


            public FoodPriceCalculator(Dictionary<string, decimal> ingredientPrices, List<yiyecek> yemekler)
            {
                this.ingredientPrices = ingredientPrices;
                this.yemekler = yemekler;

            }

            // Siparişin satış fiyatını hesaplayan metot
            // bu metodda satış fiyatları o yemeğin malzemelerinin fiyatları toplamının ile hesaplanır ve üzerine kdv oranı eklenerek son fiyatı belirlenir.
            public decimal CalculateSellingPrice(yiyecek foodItem)
            {
                decimal totalPrice = 0;

                foreach (var ingredient in foodItem.Malzemeler)
                {
                    if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                    {
                        totalPrice += price * ingredient.Value / 1000;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Ingredient price not found for: {ingredient.Key}");
                    }
                }

                // KDV oranını hesaplayıp satış fiyatını döndür
                decimal kdvRate = Convert.ToDecimal(foodItem.yiyecekKDVOrani);
                decimal sellingPrice = totalPrice * (1 + kdvRate / 100);

                return sellingPrice;
            }

            // Sipariş listesinin toplam satış fiyatını hesaplayan metot
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

                        // Malzeme isimleri ve fiyatlarını içeren ingredientPrices sözlüğünü doldur

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

                // FoodPriceCalculator sınıfının bir örneğini oluştur
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

                // yemeğin satış fiyatını hesapla ve ekrana yazdır
                    decimal sellingPrice = priceCalculator.CalculateSellingPrice(yemek); // Burada mevcut priceCalculator'ı kullan
                    Console.WriteLine($"Yemek: {yemek.Ad}, Satış Fiyatı: {sellingPrice:F2}");
                }

                yemekler = yemekAdList;

                yemekler = yemekAdList;

                yemekler = yemekAdList;
            }
            // Yemekler yüklenirken bir hata oluştuşsa bu hatayı ekrana yazdır
            catch (Exception ex)
            {
                MessageBox.Show("Yemekler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }



        // tüm yiyeceklerin fonksiyonları aynı şekildedir siparis'e butonun text i eklenerek seçilen yemek alınmış olur sonrasında yemekEkle fonksiyonu çağırılır ve siparis değişkenine alınan yemek adı siparisListesi listesine eklenir. 
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

        // yeni bir groupbox oluştur ve ürünleri içine attıktan sonra silinecekleri seçer ve onayladıktan sonra siparisleri siler. Aynı zamanda hem yetkili ekranından hemde sipariş ekranındaki sipariş txt boxundan silmektedir.
        private void silButton_Click(object sender, EventArgs e)
        {
            // Sipariş listesi boş ise hata mesajı göster ve metottan çık
            if (siparisListesi.Count == 0)
            {
                MessageBox.Show("Sipariş listesi boş.");
                return;
            }
            // GroupBox oluştur
            GroupBox groupBox = new GroupBox 
            {
                Text = "Silinecek Ürünleri Seçin",
                Dock = DockStyle.Fill
            };
            //silForm'u çağırır ve içine groupbox ve sil butonunu ekler
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
                // Sil butonu tanımlanır ve metodu yazılır burada deneme amaçlı olarak forms üzerinde form oluşturarak değil kod üzerinden panel oluşturma denenmiştir.
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

        // Sipariş onay butonuna tıklanma methodu
        private void siparisonaybtn_Click(object sender, EventArgs e)
    {
        YemekleriYukle();
        MessageBox.Show("Siparişiniz:\r\n" + string.Join(Environment.NewLine, siparisListesi));

        // CalculateTotalPrice metodu ile toplam fiyat hesaplanır ve lblFiyat label'ına yazdırılır
        
        decimal totalPrice = CalculateTotalPrice();

        // Seçilen ürünlerin fiyatlarını hesapla
        FoodPriceCalculator priceCalculator = new FoodPriceCalculator(ingredientPrices, yemekler);
        decimal sellingPrice = priceCalculator.CalculateSellingPrice(siparisListesi);

        string totalPriceText = totalPrice.ToString("F2");
        UpdateFiyatLabel(totalPriceText);

        // lblFiyat label'ına fiyat yazdırılır
        string sellingPriceText = sellingPrice.ToString("F2");
        lblFiyat.Text = $"Toplam Fiyat: {totalPriceText} TL\nSatış Fiyatı: {sellingPriceText} TL";

        // siparişin yetkili ekranında gösterilmesi için gerekli olan parametreler aktarılır
        yetkiliekrani yetkiliekraniForm = new yetkiliekrani(siparisListesi, yemekler, depo);
        yetkiliekraniForm.Show();
    }

        private void siparisekrani_Load(object sender, EventArgs e)
        {

        }

        // lblFiyat label'ını (toplam fiyatın yazıldığı label) günceller
        public void UpdateFiyatLabel(string fiyat)
        {
            lblFiyat.Text = fiyat;
        }
        // CalculateTotalPrice metodu ile toplam fiyat hesaplanır yemekler listesinden yemeğin Ad değişkenini alır ve kendi içerisindeki yiyecekFiyat tnaımlamasından yiyeceğin fiyatını alır malzeme fiyatlarını ekler ve işlemi yaparak toplam fiyatı bulup totalPrice olarak return eder.
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
