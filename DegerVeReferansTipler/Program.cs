using System;

namespace DegerVeReferansTipler
{
    // int, decimal, float, byte, bool, double, long vs.. == değer tip
    // array , class , interface , string vs .. == referans tip olarak çıkar


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

        }
    }
}
