using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Cuisinière : Electro_menager
    {
        int puisssance, nb_plaques;
        public Cuisinière(string objetid, string Type, string description, int puissance, int nb_plaques, string lieuStock, double montant, string état) : base(objetid, Type, description, lieuStock, montant, état)
        {
            this.Description = "Cuisinière";
            this.puisssance = puissance;
            this.nb_plaques = nb_plaques;
        }
        public override string ToString()
        {
            return base.ToString() + puisssance + "W;" + nb_plaques + "plaques";
        }
    }
}

