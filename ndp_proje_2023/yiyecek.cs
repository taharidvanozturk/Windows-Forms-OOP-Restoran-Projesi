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
        // Yemek malzeme fiyatlarını tutan bir sözlük (dictionary) oluşturuyorum
        private readonly Dictionary<string, decimal> ingredientPrices = new Dictionary<string, decimal>();

        public FoodPriceCalculator(Dictionary<string, decimal> ingredientPrices)
        {
            // Yemek malzeme fiyatlarını ayarlamak için sözlüğü başlatıyorum
            this.ingredientPrices = ingredientPrices;

            _ = new Dictionary<string, decimal>()
            {
              { "Roka", 7.03m },
              { "Marul", 7.41m },
              { "Salatalık", 4.64m },
              { "Domates", 9.02m },
              { "Biber", 2.63m },
              { "Zeytinyağı", 5.29m },
              { "Limon", 6.20m },
              { "Tuz", 5.28m },
              { "Yeşil biber", 7.67m },
              { "Kuru soğan", 9.52m },
              { "Karabiber", 2.78m },
              { "Roma marul", 5.38m },
              { "Tavuk göğsü", 9.91m },
              { "Kruton", 4.16m },
              { "Parmesan peyniri", 3.60m },
              { "Sezar sosu", 5.88m },
              { "Soğan", 7.93m },
              { "Nar ekşisi", 1.77m },
              { "Kabak", 7.53m },
              { "Nane", 5.03m },
              { "Tere", 9.03m },
              { "Taze soğan", 2.50m },
              { "Yoğurt", 6.53m },
              { "Sarımsak", 9.44m },
              { "Kola", 6.03m },
              { "Fanta", 1.54m },
              { "Su", 1.72m },
              { "Çay", 1.51m },
              { "Elma", 5.41m },
              { "Armut", 2.91m },
              { "Muz", 5.91m },
              { "Kivi", 8.75m },
              { "Ejder meyvesi", 4.90m },
              { "Kemal Paşa", 1.07m },
              { "Şerbet", 9.26m },
              { "Kaymak", 2.94m },
              { "Bisküvi", 2.23m },
              { "Krema", 7.86m },
              { "Çilek", 9.95m },
              { "Tel kadayıf", 7.64m },
              { "Sade yağ", 5.85m },
              { "İnce çekilmiş antep fıstığı", 3.18m },
              { "Waffle", 8.76m },
              { "Meyveler", 9.03m },
              { "Et (dana, tavuk, vb.)", 2.56m },
              { "Sebzeler (soğan, biber, domates, vb.)", 9.63m },
              { "Baharat", 1.02m },
              { "Tavuk veya dana eti", 4.14m },
              { "Sumak", 8.34m },
              { "Lavaş ekmeği", 7.36m },
              { "Kıyma", 1.14m },
              { "Mantı hamuru", 6.09m },
              { "Tavuk eti", 9.22m },
              { "Pirinç", 1.89m },
              { "Makarna", 5.58m },
              { "Domates sosu", 1.13m },
              { "Süt", 2.29m },
              { "Nişasta", 2.41m },
              { "Şeker", 8.72m }
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