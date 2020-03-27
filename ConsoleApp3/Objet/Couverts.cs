using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Couverts : Vaisselle
    {
        public Couverts(string objetid, string Type, string description, string lieuStock, double montant, string état,int nombre) : base(objetid, Type, description,nombre, lieuStock, montant, état)
        {
            this.Description = "Couverts";
        }
        
    }
}
