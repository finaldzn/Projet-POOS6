using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Personne:IPersonne<Personne>
    {
        string nom, prenom, coordonées, téléphone, identifiant;

        public Personne()
        { }
        public Personne(string nom, string prenom, string coordonées, string téléphone, string identifiant)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Coordonées = coordonées;
            this.Téléphone = téléphone;
            this.identifiant = identifiant;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Coordonées { get => coordonées; set => coordonées = value; }
        public string Téléphone { get => téléphone; set => téléphone = value; }
        public string Identifiant { get => identifiant; }

        public override string ToString()
        {
            return Identifiant +";"+Nom + ";" + Prenom + ";" + Coordonées + ";" + Téléphone;
        }
    }
}
