using System;
using System.Collections.Generic;

namespace ndp_proje_2023
{
    public class yiyecek
    {
        public string Ad { get; set; }
        public string yiyecekTuru { get; set; }
        public decimal yiyececekFiyat { get; set; }
        public string yiyecekKDVOrani { get; set; }

        public Dictionary<string, int> Malzemeler { get; set; }
    }

    public class FoodPriceCalculator
    {
        // Yemek fiyatlarını hesaplamak için kullanılan sınıf.
        // İçerisinde yemek malzeme fiyatlarını tutan bir sözlük (dictionary) bulunur.
        // Malzemelerin fiyatları kullanılarak yemeklerin satış fiyatı hesaplanır.

        // Yemek malzeme fiyatlarını tutan bir sözlük (dictionary) oluşturuyorum
        private readonly Dictionary<string, decimal> ingredientPrices = new Dictionary<string, decimal>();

        public FoodPriceCalculator(Dictionary<string, decimal> ingredientPrices)
        {
            // Yemek malzeme fiyatlarını ayarlamak için sözlüğü başlatıyorum
            this.ingredientPrices = ingredientPrices;

            // Malzeme fiyatlarını sözlüğe ekliyorum
            _ = new Dictionary<string, decimal>()
            {
                // Malzeme adı ve fiyatı çiftleri
            };
        }

        public decimal CalculateSellingPrice(yiyecek foodItem)
        {
            decimal totalPrice = 0;

            // Yiyeceğin içindeki malzemeleri gezerek fiyatları topluyoruz
            foreach (var ingredient in foodItem.Malzemeler)
            {
                // Malzemenin fiyatını sözlükten almaya çalışıyoruz
                // Eğer malzeme fiyatı bulunamazsa, örnek olarak 1 TL ekleyerek devam ediyoruz.
                if (ingredientPrices.TryGetValue(ingredient.Key, out decimal price))
                {
                    totalPrice += price * ingredient.Value;
                }
                else
                {
                    totalPrice += 1; // Malzeme fiyatı bulunamazsa, 1 TL olarak kabul ediyoruz.
                    // Alternatif olarak aşağıdaki satırı kullanarak hata fırlatabilirsiniz:
                    // throw new InvalidOperationException($"Ingredient price not found for: {ingredient.Key}");
                }
            }

            // Toplam fiyatı KDV oranına göre hesaplayarak satış fiyatını elde ediyoruz
            decimal sellingPrice = totalPrice * (1 + Convert.ToDecimal(foodItem.yiyecekKDVOrani) / 100);

            return sellingPrice;
        }
    }
}
