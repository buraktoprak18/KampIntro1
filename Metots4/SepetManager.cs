using System;
using System.Collections.Generic;
using System.Text;

namespace Metots4
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string Aciklama , double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urunAdi);

        }
    }
}
