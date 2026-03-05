using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    public class Furnizor
    {
        public string NumeCompanie { get; set; }
        public string CUI { get; set; }
        public string NrInmatriculare { get; set; }
        public string EUID { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string PersoanaContact { get; set; }

        public Furnizor(string nume, string cui, string nrInmat, string euid, string telefon, string email, string adresa, string persoana)
        {
            ///date de identificare
            NumeCompanie = nume;
            CUI = cui;
            NrInmatriculare = nrInmat;
            EUID = euid;
            
            ///date de contact
            Telefon = telefon;
            Email = email;
            Adresa = adresa;
            PersoanaContact = persoana;
        }
    }
}
