using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriId = 422;
            musteri1.MusteriAdi = "Görkem";
            musteri1.MusteriSoyadi = "Karagöl";
            musteri1.MusteriHesapNo = 324;
            musteri1.MusteriYas = 18;

            Musteri musteri2 = new Musteri();

            musteri2.MusteriId = 546;
            musteri2.MusteriAdi = "Ahmet";
            musteri2.MusteriSoyadi = "Kaya";
            musteri2.MusteriHesapNo = 192;
            musteri2.MusteriYas = 32;

            Musteri musteri3 = new Musteri();

            musteri3.MusteriId = 111;
            musteri3.MusteriAdi = "Mehmet";
            musteri3.MusteriSoyadi = "Can";
            musteri3.MusteriHesapNo = 2;
            musteri3.MusteriYas = 25;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            Console.WriteLine("----------------------------");
            musteriManager.List(musteri2);
            Console.WriteLine("----------------------------");
            musteriManager.Delete(musteri3);
            Console.WriteLine("----------------------------");
        }
    }
}
