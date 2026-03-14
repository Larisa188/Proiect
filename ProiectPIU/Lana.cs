using ProiectPIU;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectPIU
{
    public class Lana : Produs
    {
        public string Compozitie { get; set; }
        public string CodCuloare { get; set; }
        public string GrosimeFir { get; set; }
        public double MarimeRecomandatMM { get; set; }
        public double LungimeMetri { get; set; }
        public int GramajGrame { get; set; }

        public Lana(string denumire, string compozitie, string culoare, string grosime, int stoc, decimal pret, string producator, double lungime, int gramaj, double marime)
        {
            Denumire = denumire;
            Compozitie = compozitie;
            CodCuloare = culoare;
            GrosimeFir = grosime;
            CantitateStoc = stoc;
            PretPerUnitate = pret;
            Producator = producator;
            LungimeMetri = lungime;
            GramajGrame = gramaj;
            MarimeRecomandatMM = marime;
        }
    }
}
