using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    public class Vanzare
    {
        public DateTime DataVanzarii { get; set; }
        public Produs ProdusVandut { get; set; }
        public int CantitateVanduta { get; set; }
        public decimal TotalIncasat { get; set; }

        public Vanzare(Produs produs, int cantitate)
        {
            DataVanzarii = DateTime.Now;
            ProdusVandut = produs;
            CantitateVanduta = cantitate;
            TotalIncasat = cantitate * produs.PretPerUnitate;
            produs.CantitateStoc = produs.CantitateStoc - cantitate;
        }
    }
}
