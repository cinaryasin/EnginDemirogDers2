using System;

namespace EnginDemirogDers2
{
    //Syntax = bütün programlama dilleri ile yazılım geliştirilir sadece her programlama dilinin yazım şekli farklıdır.
    //Do Not Repeat Yourself = Kendini Tekrarlama
    //Değişkende tanımlanan isim değer tutucu(alias) , tuttuğu veri ise değerdir.
    class Program
    {
        static void Main(string[] args)
        {
            //Type Safety = Tip güvenliği   Verilerin tipinin yazılması zorunluluğudur.


            string kadegoriEtiketi = "Kategori";

            //int ogrenciSayisi = 1000;
            //float faizOrani = 2.15f;
            //bool sistemeGirisYapildiMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }

            bool sistemeGirisYapildiMi = true;

            if (sistemeGirisYapildiMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



            Console.WriteLine(kadegoriEtiketi);
        }
    }
}
