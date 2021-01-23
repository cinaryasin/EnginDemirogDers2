using System;
using System.Collections.Generic;

namespace OOP3
{

    //  *** interface ' i birbirlerinin alternatifi olan ama kod içeriğinin farklı olduğu durumlarda kullanırız
    //  *** Interface onu implemente eden class ın referansını tutabilir.
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            //Interface onu implemente eden class ın referansını tutabilir.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService);

            List<IKrediManager> kredis = new List<IKrediManager>()//farklı kredi seçenekleri hesaplamak istediğimizde interface list haline getirdik içeride hesaplanacak kredileri belirledik
            {
                ihtiyacKrediManager, tasitKrediManager
            };

            //basvuruManager.KrediOnBilgilendirmesiYap(kredis); //buradan hesaplıyacağımız kredileri çağırdık


        }
    }
}
