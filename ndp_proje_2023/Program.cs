using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Yemeklerin JSON dosyasından okunması
            List<yiyecek> foodItems = ReadFoodItemsFromJSON("yemekler.json");

            // Malzeme fiyatlarının CSV dosyasından okunması
            Dictionary<string, decimal> ingredientPrices = ReadIngredientPricesFromCSV("depo.txt");

            // Her yiyecek türü için maliyetin hesaplanması ve özelliklerinin ayarlanması
            foreach (var foodItem in foodItems)
            {
                if (foodItem is Salata salata)
                {
                    // Salata için malzemelerin toplam maliyetinin hesaplanması
                    decimal totalCost = 0;
                    foreach (var ingredient in salata.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // Salata özel özelliklerinin ayarlanması
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).ToString("F2"), out decimal fiyat);
                    salata.yiyececekFiyat = fiyat;
                    salata.yiyecekTuru = "Salata";
                }
                else if (foodItem is icecek icecek)
                {
                    // İçecek için malzemelerin toplam maliyetinin hesaplanması
                    decimal totalCost = 0;
                    foreach (var ingredient in icecek.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // İçecek özel özelliklerinin ayarlanması
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).ToString("F2"), out decimal fiyat);
                    icecek.yiyececekFiyat = fiyat;
                    icecek.yiyecekTuru = "İçecek";
                }
                else if (foodItem is tatli tatli)
                {
                    // Tatlı için malzemelerin toplam maliyetinin hesaplanması
                    decimal totalCost = 0;
                    foreach (var ingredient in tatli.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // Tatlı özel özelliklerinin ayarlanması
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).ToString("F2"), out decimal fiyat);
                    tatli.yiyececekFiyat = fiyat;
                    tatli.yiyecekTuru = "Tatlı";
                }
                else if (foodItem is anaYemek anaYemek)
                {
                    // Ana Yemek için malzemelerin toplam maliyetinin hesaplanması
                    decimal totalCost = 0;
                    foreach (var ingredient in anaYemek.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // Ana Yemek özel özelliklerinin ayarlanması
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).
ToString("F2"), out decimal fiyat);
                    anaYemek.yiyececekFiyat = fiyat;
                    anaYemek.yiyecekTuru = "Ana Yemek";
                }
                else if (foodItem is meyve meyve)
                {
                    // Meyve için malzemelerin toplam maliyetinin hesaplanması
                    decimal totalCost = 0;
                    foreach (var ingredient in meyve.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // Meyve özel özelliklerinin ayarlanması
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).ToString("F2"), out decimal fiyat);
                    meyve.yiyececekFiyat = fiyat;
                    meyve.yiyecekTuru = "Meyve";
                }
            }

            // Yiyecek fiyatlarını hesaplayan sınıfın oluşturulması
            FoodPriceCalculator priceCalculator = new FoodPriceCalculator(ingredientPrices);

            // Her yiyecek için satış fiyatının hesaplanması ve konsola yazdırılması
            foreach (var foodItem in foodItems)
            {
                decimal sellingPrice = priceCalculator.CalculateSellingPrice(foodItem);
                Console.WriteLine($"Food: {foodItem.Ad}, Selling Price: {sellingPrice:C}");
            }

            // Form1 adında bir Form ve txtResults adında bir TextBox oluşturulduğunu varsayalım
            siparisekrani myForm = new siparisekrani();
            TextBox txtResults = myForm.Controls.Find("txtResults", true).FirstOrDefault() as TextBox;

            if (txtResults != null)
            {
                txtResults.Text = ""; // Sonuçları göstermeden önce textbox'ı temizle
                foreach (var foodItem in foodItems)
                {
                    decimal sellingPrice = priceCalculator.CalculateSellingPrice(foodItem);
                    txtResults.AppendText($"Food: {foodItem.Ad}, Selling Price: {sellingPrice:C}\r\n");
                }
            }

            Application.Run(myForm);
        }

        // JSON dosyasından yiyecekleri okuyan metot
        static List<yiyecek> ReadFoodItemsFromJSON(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<yiyecek>>(jsonContent);
        }

        // CSV dosyasından malzeme fiyatlarını yükleyen metotlar
        static void LoadIngredientPrices(string filePath, Dictionary<string, decimal> ingredientPrices)
        {
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length == 7)
                    {
                        var ingredientName = values[0];
                        var price = decimal.Parse(values[6]);

                        ingredientPrices.Add(ingredientName, price);
                    }
                }
            }
        }

        static Dictionary<string, decimal> ReadIngredientPricesFromCSV(string filePath)
        {
            var ingredientPrices = new Dictionary<string, decimal>();
            LoadIngredientPrices(filePath, ingredientPrices);
            return ingredientPrices;
        }
    }
}