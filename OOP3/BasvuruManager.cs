using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection 
        public void BasvuruYap(IKrediManager krediManager , ILoggerService loggerService) //buraya IKrediManager göndererek aslında bütün kredi çeşitlerini göndermiş olduk. Buraya hangisini gönderirsek o çalışacak
        {
            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> kredis)
        {
            foreach (var kredi in kredis)//birden fazla yapılacak olan kredi hesaplamasını listeden döngüye aldık
            {
                kredi.Hesapla();
            }
        }
    }
}
