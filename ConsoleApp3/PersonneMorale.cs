using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    sealed class PersonneMorale:Personne,IPersonne<PersonneMorale>
    {
        string activite;
        public PersonneMorale(string identifiant, string nom, string prenom, string coordonées, string téléphone, string activite) : base(nom, prenom, coordonées, téléphone, identifiant)
        {

            this.Activite = activite;

        }

        public string Activite { get => activite; set => activite = value; }
        public override string ToString()
        {
            return base.ToString()+";"+activite;
        }
    }
}
