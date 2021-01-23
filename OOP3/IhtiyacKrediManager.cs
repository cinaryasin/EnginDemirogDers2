using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Interface kullanılan interface içerisindeki metotlar kullanılmak zorundadır ve kullanıldığı yerlerde implemente  edilir 
    class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme planı Hesaplandı");
        }
    }
}
