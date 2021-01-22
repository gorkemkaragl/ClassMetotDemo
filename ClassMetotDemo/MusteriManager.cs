using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi +
                "\nKaydınız alındı. ");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi +
                "\nBilgileriniz Listeleniyor ; " +
                "\nId numaranız : " + musteri.MusteriId +
                "\nAd ve Soyadınız : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi +
                "\nHesap Numaranız : " + musteri.MusteriHesapNo +
                "\nYaşınız : " + musteri.MusteriYas);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi +
                "\nKaydınız silindi");
        }
    }
}
