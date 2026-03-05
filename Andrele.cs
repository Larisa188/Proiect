using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    public class Andrele : Produs
    {
        public string Material { get; set; }
        public double MarimeMM { get; set; }
        public string Tip { get; set; }
        public int LungimeCablu { get; set; }

        public Andrele(string denumire, string material, double marime, string tip, int lungimeCablu, int stoc, decimal pret, string producator)
        {
            Denumire = denumire;
            Material = material;
            MarimeMM = marime;
            Tip = tip;
            LungimeCablu = lungimeCablu;
            CantitateStoc = stoc;
            PretPerUnitate = pret;
            Producator = producator;
        }
    }
}
