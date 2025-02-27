using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1
{
    public class Perisabile : Produse
    {
        public string DataExpirarii{get;set;}

       public Perisabile(string denumire, double pret, int cantitate, string dataExpirarii):base(denumire, pret, cantitate)
        {
            DataExpirarii = dataExpirarii ?? throw new ArgumentNullException(nameof(dataExpirarii));
        }

        //Metoda abstracta afisare produse
        public override void AfisareProduse()
        {
            Console.WriteLine($"Produs perisabil: {Denumire}, Pret: {Pret}, Cantitate: {Cantitate}, Data expirarii: {DataExpirarii}");
        }
    }
}