using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectPIU
{
    public abstract class Produs
    {
        public string Denumire { get; set; }
        public decimal PretPerUnitate { get; set; }
        public int CantitateStoc { get; set; }
        public string Producator { get; set; }
    }
}

