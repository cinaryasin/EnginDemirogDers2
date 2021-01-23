using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{

    //Tüzel müşteri özellikleri
    class CoorporateCustomer: Customer             //inheritance = miras
    {
        
        public string TaxNo { get; set; } // Vergi numarası
        public string CompanyName { get; set; } //Şirket adı
    }
}
