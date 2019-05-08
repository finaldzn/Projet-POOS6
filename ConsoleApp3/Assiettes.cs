using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Assiettes : Vaisselle
    {
        public Assiettes(string objetid, string Type, string description,int nombre, string lieuStock, int montant, string état) : base(objetid, Type, description,nombre, lieuStock, montant, état)
        {
            this.Description = "Assiettes";
        }
    
    }
}
