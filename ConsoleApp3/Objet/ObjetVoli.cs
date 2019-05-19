using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ObjetVoli : Objet
    {
        double hauteur, largeur, longueur;

        

        public ObjetVoli(string objetid, string type, string description, string lieuStock, double montant, double hauteur, double largeur, double longueur, string etat) :base(objetid, type, description,etat, lieuStock, montant)
        {
            base.Vendu = false;
            this.Hauteur = hauteur;
            this.Largeur = largeur;
            this.Longueur = longueur;
        }

        public double Hauteur { get => hauteur; set => hauteur = value; }
        public double Largeur { get => largeur; set => largeur = value; }
        public double Longueur { get => longueur; set => longueur = value; }
        public double Volume { get => longueur*Hauteur*Largeur; }
    }
}
