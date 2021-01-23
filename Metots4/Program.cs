using System;

namespace Metots4                                       // Do not repeat yourself-DRY-Clean Code-Best Pratice
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double fiyati = 1;
            string aciklama = "Amasya Elması";
            // FARKLI

            string[] meyveler = new string[] { };

           Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 20;

            Urun[] urunler = new Urun[] {urun1,urun2,};


            //type safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("-----------METOTLAR---------------" );
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("-----------------2.Metot---------------------");

            sepetManager.Ekle2("Armut","Yeşil", 12, 9 );
            sepetManager.Ekle2("Elma", "Kırmızı", 5, 4);
            sepetManager.Ekle2("Karpuz", "Diyarbakır", 3, 2);





        }
    }
} 
            