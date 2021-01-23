using System;
using System.Linq;

namespace OdevleAlakalı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            // int yerine var da yazabilirsin
            //int result = Add2(30);    
            // eğer alttaki 20 yi değilde 30 u almak istiyorsan "değer tip" değil "referans tip" olarak almamız gerekir nasıl yapıcam diyorsan basına ref getir
            // ref in alternetatifi out'tur.outun farkı number 1in değeri olmasına gerek yok out metotun ıcınde yazılmalı sayı
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(number1, number2);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add4(1,2,3,4));
            //Console.WriteLine(number1);
            //Console.ReadLine();

        }
        static void Add()
        {
            Console.WriteLine("Added!");

        }
        // number2=20 dersen default olarak 2yi 20 olarak belirlersin default en sonunda olmalı 
      
        static int Add2(int x, int number1=29, int number2=20)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // çarpma metotu
        // iki sayı çarpma 
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;

        }
        // üç sayıyı çarpma 
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;

        }

       // params keywordu
       //Paramsdan sonra herhangi bir int gelemez

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();

        }
       









    }
}
