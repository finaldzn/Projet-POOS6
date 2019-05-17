using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Lave_Linge:Electro_menager
    {
        public Lave_Linge(string objetid, string Type, string description, string lieuStock, double montant, string etat) : base(objetid, Type, description, lieuStock, montant, etat)
        {
            this.Description = "Lave_Linge";
        }
    }
}
