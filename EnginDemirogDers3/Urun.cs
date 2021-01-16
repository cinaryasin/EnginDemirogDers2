using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogDers3
{
    public class Urun
    {
        //property - özellik
        public int Id { get; set; }
        public string adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
