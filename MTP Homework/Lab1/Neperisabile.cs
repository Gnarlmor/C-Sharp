using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1
{
    public class Neperisabile : Produse
    {
        public string TermenValabilitate{get;set;}

        public Neperisabile(string denumire, double pret, int cantitate, string termenValabilitate):base(denumire, pret, cantitate)
        {
            termenValabilitate = TermenValabilitate ?? throw new ArgumentNullException(nameof(termenValabilitate));
        }

        public override void AfisareProduse()
        {
            Console.WriteLine($"Produs neperisabil: {Denumire}, Pret: {Pret}, Cantitate: {Cantitate}, Termen de Valabilitate: {TermenValabilitate}");
        }
    }
}