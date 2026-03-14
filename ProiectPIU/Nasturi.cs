using ProiectPIU;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectPIU
{
    public class Nasturi : Produs
    {
        public string Forma { get; set; }
        public string Culoare { get; set; }
        public double DiametruMM { get; set; }
        public string Material { get; set; }
        public string Model { get; set; }
        public string TipPrindere { get; set; }

        public Nasturi(string denumire, string forma, string culoare, double diametru, string material,
                       string model, string tipPrindere, int stoc, decimal pret, string producator)
        {
            Denumire = denumire;
            Forma = forma;
            Culoare = culoare;
            DiametruMM = diametru;
            Material = material;
            Model = model;
            TipPrindere = tipPrindere;
            CantitateStoc = stoc;
            PretPerUnitate = pret;
            Producator = producator;
        }
    }
}
