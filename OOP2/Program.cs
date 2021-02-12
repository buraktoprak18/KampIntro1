using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Burak        
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "18";
            musteri1.Adi = "Burak";
            musteri1.Soyadi = "Toprak";
            musteri1.TcNo = "118";

            //kodlamaio
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "11";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "121212";

            // Gerçek Müşteri - Tüzel Müşteri 
            // SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

         


        }
    }
}
