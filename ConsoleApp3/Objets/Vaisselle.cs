using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Vaisselle : Objet
    {
        int nombre;
        public Vaisselle(string objetid, string Type, string description,int nombre, string lieuStock, int montant, string état) : base(objetid, Type, description, état, lieuStock, montant)
        {
            this.nombre = nombre;
            this.Type = "Cuisine";
        }
        public int Nombre { get { return this.nombre; } }

    }
}
