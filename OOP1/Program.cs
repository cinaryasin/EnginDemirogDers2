using System;

//PascalCase  her ismin baş harfi büyük   //camelCase  ilk kelimenin baş harfi küçük diğer kelimenin baş harfi büyük
//case sensitive  = küçük büyük harf duyarlılığı
namespace OOP1
{
    //class lar özellik ve medot operasyonlar barındıran classlar olarak ikiye ayrılır
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id = 1,
                CategoryId = 2,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitInStock = 3

            };
            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitInStock = 5

            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);


        }
    }
}
