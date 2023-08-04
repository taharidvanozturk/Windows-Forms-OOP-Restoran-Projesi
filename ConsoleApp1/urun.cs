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

    public Urun(string urunAdi)
    {
        this.urunAdi = urunAdi;
        RandomizeValues();
        WriteToDepoFile();
    }

    public string UrunAdi { get { return urunAdi; } }

    public object UretimTarihi { get; internal set; }

    private void RandomizeValues()
    {
        Random random = new Random();

        uretimTarihi = DateTime.Now.Date.AddDays(-random.Next(365));

        sonKullanmaTarihi = DateTime.Now.Date.AddDays(random.Next(365, 730));

        kaloriGram = random.Next(50, 501);

        stokAdet = random.Next(1001);

        fiyat = (float)random.NextDouble() * 100;
    }

    private void WriteToDepoFile()
    {
        using (StreamWriter writer = File.AppendText("depo.txt"))
        {
            writer.WriteLine($"{urunAdi} --- {stokAdet}");
        }
    }

    // Methods for Kayıt ekleme, kayıt silme, kayıt güncelleme, rapor alma can be added here.

    public static List<Urun> ReadUrunlerFromMalzemelerFile(string filePath)
    {
        List<Urun> urunler = new List<Urun>();
        string[] productNames = File.ReadAllLines(filePath);

        foreach (string productName in productNames)
        {
            Urun urun = new Urun(productName);
            urunler.Add(urun);
        }

        return urunler;
    }
}
