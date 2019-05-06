using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    sealed class MembreAsso:Personne,IPersonne<MembreAsso>
    {
        string fonction;
        
        

        public MembreAsso(string identifiant,string nom, string prenom, string coordonées, string téléphone, string fonction) : base(nom, prenom, coordonées, téléphone, identifiant)
        {
            
            this.fonction =fonction;

        }
        public override string ToString()
        {
            return base.ToString()+";"+fonction;
        }

    }
}
