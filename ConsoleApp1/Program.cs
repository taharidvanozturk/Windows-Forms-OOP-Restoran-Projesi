using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{

    internal class Urun
    {
        public string UrunAdi { get; set; }
        public DateTime UretimTarihi { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public float KaloriGram { get; set; }
        public float StokAdet { get; set; }
        public float Fiyat { get; set; }

        public static List<Urun> ReadUrunlerFromMalzemelerFile(string fileName)
        {
            List<string> malzemeler = new List<string>();

            // Read product names from the file
            try
            {
                malzemeler = File.ReadAllLines(fileName).ToList();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Dosya bulunamadı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dosya okunurken bir hata oluştu: " + ex.Message);
            }

            // Remove duplicates from the list
            malzemeler = malzemeler.Distinct().ToList();

            // Create Urun objects with random values
            List<Urun> urunler = new List<Urun>();
            Random random = new Random();

            foreach (var malzeme in malzemeler)
            {
                Urun urun = new Urun
                {
                    UrunAdi = malzeme,
                    UretimTarihi = DateTime.Today.AddDays(random.Next(-30, 0)), // Random date in the last 30 days
                    SonKullanmaTarihi = DateTime.Today.AddDays(random.Next(30, 365)), // Random date in the next year
                    KaloriGram = random.Next(50, 500), // Random value between 50 and 500
                    StokAdet = random.Next(10, 1000), // Random value between 10 and 1000
                    Fiyat = (float)(random.NextDouble() * (10 - 1) + 1) // Random value between 1 and 10 (float)
                };

                urunler.Add(urun);
            }

            return urunler;
        }

        // Additional methods for writing Urun data to "depo.txt" can be added here
        // ...
 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read product names from "malzemeler.txt" and create Urun objects
            List<Urun> urunler = Urun.ReadUrunlerFromMalzemelerFile("malzemeler.txt");

            // Print the product names and their properties
            foreach (var urun in urunler)
            {
                Console.WriteLine($"Ürün Adı: {urun.UrunAdi}");
                Console.WriteLine($"Üretim Tarihi: {urun.UretimTarihi.ToShortDateString()}");
                Console.WriteLine($"Son Kullanma Tarihi: {urun.SonKullanmaTarihi.ToShortDateString()}");
                Console.WriteLine($"Kalori (Gram): {urun.KaloriGram}");
                Console.WriteLine($"Stok Adet: {urun.StokAdet}");
                Console.WriteLine($"Fiyat: {urun.Fiyat:C}");
                Console.WriteLine();
            }

            // Write the data to "depo.txt"
            foreach (var urun in urunler)
            {
                // Modify the format as needed for your specific requirements
                string depoLine = $"{urun.UrunAdi},{urun.UretimTarihi},{urun.SonKullanmaTarihi},{urun.KaloriGram},{urun.StokAdet},{urun.Fiyat}";
                File.AppendAllText("depo.txt", depoLine + Environment.NewLine);
            }

            Console.ReadLine();
        }
    }
}
