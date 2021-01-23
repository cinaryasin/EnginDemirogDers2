using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {

        /*Arraylarda belirlediğiniz sınırların dışına çıkamazsınız yeni bir elemaan eklemek istediğinizde 
        yeni referans oluşturmanız gerekecek o yüzden array yerine collections oluştururuz.*/


        static void Main(string[] args)
        {
            //array
            string[] name = new string[]
            {
                "Yasin", "Muhsin","Asaf","Metin"
            };
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
            Console.WriteLine(name[3]);



            //collections
            List<string> isimler = new List<string>() 
            {
                "Yasin", "Muhsin","Asaf","Metin"

            };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("İlker"); // collectionlarda yeni bir eleman eklemek istediğimizde rahatlıkla add ile ekleme yapabiliriz.
            Console.WriteLine(isimler[4]); //ekleme yaptığımızda 4. indekside çağırabiliyoruz






        }
       
    }
}
