using System;
using System.Collections.Generic;
using System.IO;

public class Urun
{
    private string urunAdi;
    private DateTime uretimTarihi;
    private DateTime sonKullanmaTarihi;
    private float kaloriGram;
    private float stokAdet;
    private float fiyat;

    // Ürün sınıfı yapıcı metodu
    public Urun(string urunAdi)
    {
        // Ürün adını ayarlayın ve diğer özelliklerin değerlerini rastgeleleştirin
        this.urunAdi = urunAdi;
        RandomizeValues();
        // Rastgeleleştirilmiş ürünü depo dosyasına yazın
        WriteToDepoFile();
    }

    // Ürün adına okuma erişimi için özellik (property)
    public string UrunAdi { get { return urunAdi; } }

    // Özellikleri rastgeleleştiren metot
    private void RandomizeValues()
    {
        Random random = new Random();

        // Üretim tarihini, bugünden geriye doğru 0 ile 365 gün arasında rastgele seçin
        uretimTarihi = DateTime.Now.Date.AddDays(-random.Next(365));

        // Son kullanma tarihini, bugünden ileriye doğru 365 ile 730 gün arasında rastgele seçin
        sonKullanmaTarihi = DateTime.Now.Date.AddDays(random.Next(365, 730));

        // Kalori miktarını, 50 ile 500 arasında rastgele seçin
        kaloriGram = random.Next(50, 501);

        // Stok adetini, 0 ile 1000 arasında rastgele seçin
        stokAdet = random.Next(1001);

        // Ürün fiyatını, 1 ile 100 arasında rastgele seçin
        fiyat = (float)random.NextDouble() * 100;
    }

    // Ürünü depo dosyasına yazan metot
    private void WriteToDepoFile()
    {
        // "depo.txt" dosyasını açar ve ürün bilgilerini ekler
        using (StreamWriter writer = File.AppendText("depo.txt"))
        {
            writer.WriteLine($"{urunAdi} --- {stokAdet}");
        }
    }

    // "malzemeler.txt" dosyasından ürün adlarını okuyan ve ürünleri oluşturan metot
    public static List<Urun> ReadUrunlerFromMalzemelerFile(string filePath)
    {
        List<Urun> urunler = new List<Urun>();
        // Dosyadan ürün adlarını satır satır oku
        string[] productNames = File.ReadAllLines(filePath);

        foreach (string productName in productNames)
        {
            // Her ürün adı için yeni bir Ürün nesnesi oluştur ve listeye ekle
            Urun urun = new Urun(productName);
            urunler.Add(urun);
        }

        return urunler;
    }

    // Kayıt ekleme, kayıt silme, kayıt güncelleme, rapor alma gibi diğer metotlar da buraya eklenebilir.
}
