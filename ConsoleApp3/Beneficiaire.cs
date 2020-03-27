using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    sealed class Beneficiaire:Personne,IPersonne<Beneficiaire>
    {
        string dob;
        public Beneficiaire()
        {

        }
        public Beneficiaire(string identifiant, string nom, string prenom, string coordonées, string téléphone, string dob) : base(nom, prenom, coordonées, téléphone, identifiant)
        {

            this.Dob = dob;

        }

        public string Dob { get => dob; set => dob = value; }

        public override string ToString()
        {
            return base.ToString()+";"+Dob;
        }

    }
}
