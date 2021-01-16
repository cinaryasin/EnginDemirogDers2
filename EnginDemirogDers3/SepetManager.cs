using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogDers3
{
    class SepetManager
    {
        
        
        //Naming convention
        //Syntax = yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi);
        }

    }
}
