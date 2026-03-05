using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    public class Crosete : Produs
    {
        public double MarimeMM { get; set; }
        public string TipManer { get; set; }
        public string Culoare { get; set; }

        public Crosete(string denumire, double marime, string tipManer, string culoare, int stoc, decimal pret, string producator)
        {
            Denumire = denumire;
            MarimeMM = marime;
            TipManer = tipManer;
            Culoare = culoare;
            CantitateStoc = stoc;
            PretPerUnitate = pret;
            Producator = producator;
        }
    }
}
