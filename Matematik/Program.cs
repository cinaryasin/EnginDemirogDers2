using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
           
            dortIslem.Topla(20, 10);
            dortIslem.Cikar(20, 2);
            dortIslem.Carp(20, 2);
            dortIslem.Bol(20, 2);

        }
    }
}
