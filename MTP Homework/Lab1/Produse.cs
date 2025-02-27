using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class Produse
    {
        public string Denumire{get; set;}
        public double Pret{get; set;}
        public int Cantitate{get; set;}

        public Produse( string denumire, double pret, int cantitate)
        {
            
            denumire = Denumire;
            pret = Pret;
            cantitate = Cantitate;
        }

        //Metoda abstracta afisare produse
        public abstract void AfisareProduse();
    }
}