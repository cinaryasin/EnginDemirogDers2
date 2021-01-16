using System;

namespace EnginDemirogDers3
{   // Metodlar = tekrar tekrar kullanma olasılığı sağlayan kod bloklarıdır.
    //Do not repeat yourself = kendini tekrar etme
    //Clean code = Temiz kod yazma
    //Best Practice = Doğru uygulama teknikleri

    //Type-safe = tip güvenli programlama dilidir
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //class' ın örneği

            urun1.Id = 1;
            urun1.adi = "elma";
            urun1.Fiyati = 10.5;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun(); //class' ın örneği

            urun2.Id = 2;
            urun2.adi = "armut";
            urun2.Fiyati = 12.1;
            urun2.Aciklama = "Armut'un iyisi ayılarındır.";

            Urun[] urun = new Urun[]
            {
                urun1,urun2
            };

            foreach (var uruns in urun)
            {
                Console.WriteLine(uruns.Id);
                Console.WriteLine(uruns.adi);
                Console.WriteLine(uruns.Fiyati);
                Console.WriteLine(uruns.Aciklama);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("++++++++++++++METODLAR+++++++++++++++");
            //instance - örnek
            //Encapsulation = Kapsülleme nesne yönelimli programlamada herhangi bir nesnenin metotlarını, verilerini ve değiskenlerini diğer nesnelerden saklayarak ve bunlara erişimini sınırlandırarak yanlış kullanımlardan koruyan bir konsepttir.
            SepetManager sepetManager = new SepetManager();
            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2(urun1.adi, urun1.Aciklama, urun1.Fiyati);

        }
    }
}
