using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1
{
    public class Magazin
    {
        public List<Produse> produse;

        //Initializam constructorul pentru lista noastra de produse
        public Magazin()
            {
                //Orice produs nou adaugat se va stoca in lista de produse
                produse = new List<Produse>();
            }

        //Metoda pentru adaugarea unui elementelor in lista
        public void AddProduct(Produse produs)
        {
            produse.Add(produs);
        }

        //Metoda pentru scoaterea unui in lista
        public void RemoveProduct(Produse produs)
        {
            produse.Remove(produs);
        }

        //Method to display all the products in the store
        public void DisplayAllProducts()
        {
            foreach(var produs in produse)
            {
                produs.AfisareProduse();
            }
        }
    }
}