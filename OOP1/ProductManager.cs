using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{ // CRUD = Cread eklemek, Read okumak, Update güncellemek, Delete silmek operasyonlar manager de tutulur genelde veya service

    //void = git ve o işi yap

    //void neden kullanılı ? ==
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "  Added");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "  Updated");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + "  Updated");
        }


    }
}
