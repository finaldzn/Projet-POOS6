using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Réfrigérateur : Electro_menager
    {
        public Réfrigérateur(string objetid, string Type, string description, string lieuStock, int montant) : base(objetid, Type, description, lieuStock, montant)
        {
            this.Description = "Réfrigérateur";
        }
    }
}
