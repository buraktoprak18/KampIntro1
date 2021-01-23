using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "temel kurs";
            string kurs3 = "java kursu";

            //dizilerde tutarız - array

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kamp" , "temel kurs", "java", "phton", "c#"};


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            


            Console.WriteLine("Sayfa Sonu-footer");
        }
    }
}
