using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array = dizi   Birden fazla veri tutmak için
            string[] kurslar = new string[] 
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs"
            };
            

            foreach (var kurs in kurslar)//Dizileri tek tek dolaşmaya yarıyor. Dizilerde for döngüsünden daha kullanışlı oluyor.
            {
                Console.WriteLine(kurs);
            }
            
            for (int i = 0; i <kurslar.Length; i++) //length eleman sayısını uzunluğunu verir bize
            {
                Console.WriteLine(kurslar[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
