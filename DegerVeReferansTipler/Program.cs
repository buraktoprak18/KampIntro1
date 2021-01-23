using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = 30
            // STACK == DEĞER TİP sayi1=10 sayi2=30   EŞİT DEDİĞİN ZAMAN 10 GİDİYOR 30 OLUYOR ORASI 

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1= 999
         
            // int , decimal , float , double , bool (0,1) == DEĞER TİP
            // array, class, interface ==  REFERANS TİP 
            

            // STACM == 101/sayilar1,  102/sayilar2         101 ==> 102 olur 
            // HEAP  == 101/[10,20,30], 102/[100,200,300]
            



        }
    }
}
