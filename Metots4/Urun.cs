﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metots4
{
    class Urun
    {
        //property - özellik 
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}