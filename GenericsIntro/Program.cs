using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //işareteler arasına hangi class ı yazarsan o türde bir dizi olur string,int...
            MyList <string> isimler = new MyList<string>();
            isimler.Add("Burak");
        }
    }
}
