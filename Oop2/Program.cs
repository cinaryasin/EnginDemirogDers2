using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //gerçek müşteri
            IndividualCustomer ındividualCustomer = new IndividualCustomer()
            {
                Id = 1,
                CustomerNo = "1905",
                FirstName = "Yasin",
                LastName = "Çınar",
                TcNo = "151551155"

            };  

            //tüzel müşteri
            CoorporateCustomer coorporate = new CoorporateCustomer()
            {
                Id = 1,
                CustomerNo = "0019",
                CompanyName = "Vector Art",
                TaxNo = "19051905"

            };  


            //Müşteri yani Customer inheritance olduğu classların referansını tutabiliyor. !!!!!

            Customer customer1 = new IndividualCustomer();

            Customer customer2 = new CoorporateCustomer();



            CustomerManager customerManager = new CustomerManager(); //Customer Manager de customer çağırdığımız için customer içerisindekileri managerdede çağırabiliyoruz. 
            customerManager.Add(coorporate); 
            customerManager.Add(ındividualCustomer);

        }
    }
}
