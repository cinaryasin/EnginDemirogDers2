using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{

    //Gerçek müşteri özellikleri
    class IndividualCustomer: Customer       //inheritance = miras
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; } //adı
        public string LastName { get; set; } //soyadı
    }
}
