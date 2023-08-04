using System;
using System.Collections.Generic;

namespace ndp_proje_2023
{
    public class yiyecek
    {
        internal int yiyecekStok;

        public string Ad { get; set; }
        public string yiyecekTuru { get; set; }
        public decimal yiyececekFiyat { get; set; }
        public string yiyecekKDVOrani { get; set; }

        public Dictionary<string, int> Malzemeler { get; set; }


    }


    public class FoodPriceCalculator
    {
        private readonly Dictionary<string, decimal> ingredientPrices = new Dictionary<string, decimal>();

        public FoodPriceCalculator(Dictionary<string, decimal> ingredientPrices)
        {
            // Load ingredient prices from depolar.txt file (assuming it is in CSV format: IngredientName,Price)
            LoadIngredientPrices();
        }

        private void LoadIngredientPrices()
        {
            // Read depolar.txt file and populate the ingredientPrices dictionary
            // Example:
            // ingredientPrices.Add("Malzeme1", 10.5m);
            // ingredientPrices.Add("Malzeme2", 5.25m);
            // ...
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

            // Calculate the selling price based on the totalPrice and KDV rate (assuming KDV is a percentage)
            decimal sellingPrice = totalPrice * (1 + Convert.ToDecimal(foodItem.yiyecekKDVOrani) / 100);

            return sellingPrice;
        }
    }
}

