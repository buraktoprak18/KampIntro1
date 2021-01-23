using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] insanlar = new string[] { };

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Burak";
            musteri1.Soyadi = "Toprak";
            musteri1.krediPuani = 10;
            musteri1.Tcno = 18181818;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Zeki Eren";
            musteri2.Soyadi = "Gülbahar";
            musteri2.krediPuani = 1;
            musteri2.Tcno = 28282828;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ahmet Melih";
            musteri3.Soyadi = "Köse";
            musteri3.krediPuani = 100;
            musteri3.Tcno = 52525252;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.krediPuani);
                Console.WriteLine(musteri.Tcno);
                Console.WriteLine("---------------------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);




        }

     
       
    }
}
