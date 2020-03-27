using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Electro_menager : Objet
    {
        public Electro_menager(string objetid, string Type, string description, string lieuStock, int montant, string état) : base(objetid, Type, description, état, lieuStock, montant)
        {
            this.Type = "Cuisine";
        }
    }
}
