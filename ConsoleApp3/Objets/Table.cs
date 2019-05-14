using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Table : MobilierSalleCuisine
    {
        string forme;

        public Table(string objetid, string Type, string description,string forme, string lieuStock, int montant, string état) : base(objetid, Type, description, lieuStock, montant,état)
        {
            this.Description = "Table";
            if (forme == "carrée" || forme == "rectangulaire " || forme == "ronde") { this.forme = forme; }

        }
        public override string ToString()
        {
            return base.ToString() + ";" + forme;
        }
    }
}
