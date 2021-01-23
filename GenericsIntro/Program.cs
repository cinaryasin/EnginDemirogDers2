using System;


namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("yasin");

            Console.WriteLine(myList.Length);
            myList.Add("Asaf");

            Console.WriteLine(myList.Length);
            foreach (var isim in myList.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
