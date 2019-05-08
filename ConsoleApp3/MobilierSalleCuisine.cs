using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MobilierSalleCuisine : Objet
    {
       
        public MobilierSalleCuisine(string objetid, string Type, string description, string lieuStock, int montant, string état) : base(objetid, Type, description, lieuStock, montant,état)
        {
            //on vérifie le type de mobilier
            if(Type == "Salle" || Type == "Cuisine " || Type == "salle" || Type == "cuisine ") { this.Type = Type; }

        }

    }
}
