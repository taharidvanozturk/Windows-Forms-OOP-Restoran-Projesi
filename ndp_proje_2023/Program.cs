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

            List<yiyecek> foodItems = ReadFoodItemsFromJSON("yemekler.json");
            Dictionary<string, decimal> ingredientPrices = ReadIngredientPricesFromCSV("depo.txt");

            foreach (var foodItem in foodItems)
            {
                if (foodItem is Salata salata)
                {
                    // Calculate the total cost of the ingredients for Salata
                    decimal totalCost = 0;
                    foreach (var ingredient in salata.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // Set Salata-specific properties
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).ToString("F2"), out decimal fiyat);
                    salata.yiyececekFiyat = fiyat;
                    salata.yiyecekTuru = "Salata";
                }
                else if (foodItem is icecek icecek)
                {
                    // Calculate the total cost of the ingredients for Icecek
                    decimal totalCost = 0;
                    foreach (var ingredient in icecek.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // Set Icecek-specific properties
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).ToString("F2"), out decimal fiyat);
                    icecek.yiyececekFiyat = fiyat;
                    icecek.yiyecekTuru = "İçecek";
                }
                else if (foodItem is tatli tatli)
                {
                    // Calculate the total cost of the ingredients for Tatli
                    decimal totalCost = 0;
                    foreach (var ingredient in tatli.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // Set Tatli-specific properties
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).ToString("F2"), out decimal fiyat);
                    tatli.yiyececekFiyat = fiyat;
                    tatli.yiyecekTuru = "Tatlı";
                }
                else if (foodItem is anaYemek anaYemek)
                {
                    // Calculate the total cost of the ingredients for Ana Yemek
                    decimal totalCost = 0;
                    foreach (var ingredient in anaYemek.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // Set Ana Yemek-specific properties
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).ToString("F2"), out decimal fiyat);
                    anaYemek.yiyececekFiyat = fiyat;
                    anaYemek.yiyecekTuru = "Ana Yemek";
                }
                else if (foodItem is meyve meyve)
                {
                    // Calculate the total cost of the ingredients for Meyve
                    decimal totalCost = 0;
                    foreach (var ingredient in meyve.Malzemeler)
                    {
                        if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                        {
                            totalCost += price * ingredient.Value;
                        }
                    }

                    // Set Meyve-specific properties
                    decimal.TryParse((totalCost * 2 + totalCost * 20 / 100).ToString("F2"), out decimal fiyat);
                    meyve.yiyececekFiyat = fiyat;
                    meyve.yiyecekTuru = "Meyve";
                }
            }

            FoodPriceCalculator priceCalculator = new FoodPriceCalculator(ingredientPrices);
            foreach (var foodItem in foodItems)
            {
                decimal sellingPrice = priceCalculator.CalculateSellingPrice(foodItem);
                Console.WriteLine($"Food: {foodItem.Ad}, Selling Price: {sellingPrice:C}");
            }
            // Assuming you have created a Form named "Form1" and a TextBox named "txtResults"
            siparisekrani myForm = new siparisekrani();
            TextBox txtResults = myForm.Controls.Find("txtResults", true).FirstOrDefault() as TextBox;

            if (txtResults != null)
            {
                txtResults.Text = ""; // Clear the textbox before showing results
                foreach (var foodItem in foodItems)
                {
                    decimal sellingPrice = priceCalculator.CalculateSellingPrice(foodItem);
                    txtResults.AppendText($"Food: {foodItem.Ad}, Selling Price: {sellingPrice:C}\r\n");
                }
            }

            Application.Run(myForm);


        }

        static List<yiyecek> ReadFoodItemsFromJSON(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<yiyecek>>(jsonContent);
        }

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
