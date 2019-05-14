using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Armoires : MobilierChambre
    {
        public Armoires(string objetid, string Type, string description, string lieuStock, int montant, string état) : base(objetid, Type, description, lieuStock, montant,état)
        {
            this.Description = "Armoire";
        }
    }
}
