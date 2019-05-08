using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MobilierChambre : Objet
    {
        public MobilierChambre(string objetid, string Type, string description, string lieuStock, int montant):base(objetid, Type, description, lieuStock, montant)
            {
            this.Type = "Chambre";
            }
    }
}
