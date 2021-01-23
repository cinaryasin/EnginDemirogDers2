using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //içerisindeki hesaplamalar farklı olacak classtan interface ye dönüştürdük. 
    //İnterface = Birisi bu interface kullanırsa içindeki metotları kullanmak zorunda
    interface IKrediManager   //bir interfacedi ve bunu implemente eden classlar bunun içerisindeki metotları doldurmak zorundadır.
    {
        void Hesapla();
        void BiseyYap();
        
    }
}
