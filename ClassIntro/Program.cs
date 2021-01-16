using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kurs kurs1;  classlarda değişken tanımlayabilirsin 

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Mustafa Murat Coşkun";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Kerem Varış";
            kurs3.IzlenmeOrani = 70;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            
            
            
            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2, kurs3

            };
            
            
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen +" -> "+ kurs.KursAdi + " : " + kurs.IzlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
