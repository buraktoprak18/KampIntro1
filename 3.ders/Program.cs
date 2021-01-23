using System;

namespace _3.ders
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Burak";
            int yas = 20;
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Burak Toprak";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Phyton";
            kurs2.KursunEgitmeni = "Eren G";
            kurs2.İzlenmeOrani = 2;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursunEgitmeni = "A.Melih";
            kurs3.İzlenmeOrani = 20;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
            }
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string KursunEgitmeni { get; set; }
            public int  İzlenmeOrani{ get; set; }



        }



    }
}
