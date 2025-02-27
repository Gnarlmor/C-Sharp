using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1
{
    public class Produse
    {
        private long codDeBare;
        public string denumireProdus{get; set;}
        public string producatorProdus{get; set;}
        public float pretProdus{get; set;}

        public Produse(long bar, string denumire, string producator, float pret)
        {
            bar = codDeBare;
            denumire = denumireProdus;
            producator = producatorProdus;
            pret = pretProdus;
        }

        public long codBar
        {
            get
            {
                return codDeBare;
            }
            set
            {
                if(value > 0)
                codDeBare = value;
            }
        }
    }
}