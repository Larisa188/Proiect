using ProiectPIU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace ProiectPIU
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cerința: Salvarea datelor într-un vector (Listă) de obiecte
            List<Produs> inventar = new List<Produs>();
            bool activ = true;

            while (activ)
            {
                Console.WriteLine("\n--- MENIU GESTIUNE MERCERIE ---");
                Console.WriteLine("1. Adauga Produs (Citire de la tastatura)");
                Console.WriteLine("2. Afiseaza toate produsele");
                Console.WriteLine("3. Cautare după denumire");
                Console.WriteLine("0. Iesire");
                Console.Write("Alege optiunea: ");

                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        // Cerința: Citirea datelor de la tastatură
                        AdaugaProdus(inventar);
                        break;
                    case "2":
                        // Cerința: Afișarea datelor dintr-un vector
                        AfiseazaProduse(inventar);
                        break;
                    case "3":
                        // Cerința: Căutarea după anumite criterii
                        CautaProdus(inventar);
                        break;
                    case "0":
                        Console.WriteLine("Aplicatia va fi inchisa");
                        return;

                    default:
                        Console.WriteLine("Opțiune invalidă!");
                        break;
                }
            }
        }

        static void AdaugaProdus(List<Produs> lista)
        { 
            Console.Write("Introduceti denumirea: ");
            string denumire = Console.ReadLine().ToLower();
            Console.Write("Introduceti pretul: ");
            decimal pret = decimal.Parse(Console.ReadLine());
            Console.Write("Introduceti stocul: ");
            int stoc = int.Parse(Console.ReadLine());
            Console.Write("Introduceti producatorul: ");
            string prod = Console.ReadLine();

            if (denumire == "lana")
            {
                Console.Write("Compozitie: ");
                string comp = Console.ReadLine();
                Console.Write("Culoare: ");
                string cul = Console.ReadLine();
                Console.Write("Grosime: ");
                string gros = Console.ReadLine();
                Console.Write("Lungime(m): ");
                double len = double.Parse(Console.ReadLine());
                Console.Write("Gramaj(g): ");
                int gr = int.Parse(Console.ReadLine());
                Console.Write("Marime recomandata: ");
                double rec = double.Parse(Console.ReadLine());


                lista.Add(new Lana(denumire, comp, cul, gros, stoc, pret, prod, len, gr, rec));
            }
            else if (denumire == "andrele")
            {
                Console.Write("Material: ");
                string mat = Console.ReadLine();
                Console.Write("Marime MM: ");
                double mar = double.Parse(Console.ReadLine());
                Console.Write("Tip: ");
                string tip = Console.ReadLine();
                Console.Write("Lungime Cablu: ");
                int cablu = int.Parse(Console.ReadLine());


                lista.Add(new Andrele(denumire, mat, mar, tip, cablu, stoc, pret, prod));
            }
            else if (denumire == "nasturi")
            {
                Console.Write("Forma: ");
                string forma = Console.ReadLine();
                Console.Write("Culoare: ");
                string culN = Console.ReadLine();
                Console.Write("Diametru: ");
                double dia = double.Parse(Console.ReadLine());
                Console.Write("Material: ");
                string matN = Console.ReadLine();
                Console.Write("Model: ");
                string mod = Console.ReadLine();
                Console.Write("Tip prindere: ");
                string prin = Console.ReadLine();

                lista.Add(new Nasturi(denumire, forma, culN, dia, matN, mod, prin, stoc, pret, prod));
            }
            else if (denumire == "crosete")
            {
                Console.Write("Marime MM: ");
                double mar = double.Parse(Console.ReadLine());

                Console.Write("Tip Mâner: ");
                string maner = Console.ReadLine();

                Console.Write("Culoare: ");
                string cul = Console.ReadLine();

                lista.Add(new Crosete(denumire, mar, maner, cul, stoc, pret, prod));
            }
            else
            {
                Console.WriteLine("Produs necunoscut. Nu s-au putut cere date specifice.");
            }

            Console.WriteLine("\nProdusul a fost salvat!");


        }

        static void AfiseazaProduse(List<Produs> lista)
        {
            Console.WriteLine("\n--- LISTA PRODUSE ---");
            if (lista.Count == 0) Console.WriteLine("Vectorul este gol.");

            foreach (var p in lista)
            {

                Console.Write($"[{p.GetType().Name}] Nume: {p.Denumire} | Stoc: {p.CantitateStoc} | Pret: {p.PretPerUnitate} lei");

                if (p is Lana l)
                {
                    Console.WriteLine($" | Compozitie: {l.Compozitie}, Gramaj: {l.GramajGrame}g");
                }
                else if (p is Andrele a)
                {
                    Console.WriteLine($" | Material: {a.Material}, Marime: {a.MarimeMM}mm");
                }
                else if (p is Crosete c)
                {
                    Console.WriteLine($" | Marime: {c.MarimeMM}mm, Maner: {c.TipManer}");
                }
                else if (p is Nasturi n)
                {
                    Console.WriteLine($" | Forma: {n.Forma}, Material: {n.Material}");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

            static void CautaProdus(List<Produs> lista)
            {
                Console.Write("\nIntroduceti denumirea produsului cautat: ");
                string numeCautat = Console.ReadLine().ToLower();

                
                var rezultate = lista.Where(p => p.Denumire.ToLower().Contains(numeCautat)).ToList();

                if (rezultate.Count > 0)
                {
                    Console.WriteLine($"\nAm găsit {rezultate.Count} rezultate:");
                    foreach (var p in rezultate)
                    {
                        Console.Write($"-> [{p.GetType().Name}] {p.Denumire} | Pret: {p.PretPerUnitate} | Stoc: {p.CantitateStoc}");

                        if (p is Lana l)
                        {
                            Console.WriteLine($" | Compoziție: {l.Compozitie}");
                        }
                        else if (p is Andrele a)
                        {
                            Console.WriteLine($" | Material: {a.Material} | Mărime: {a.MarimeMM}mm");
                        }
                        else if (p is Crosete c)
                        {
                            Console.WriteLine($" | Mărime: {c.MarimeMM}mm");
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nu a fost găsit niciun produs cu această denumire.");
                }
            }
     }
}