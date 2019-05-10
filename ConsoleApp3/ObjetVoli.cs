using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ObjetVoli : Objet
    {
        int hauteur, largeur, longueur;

        

        public ObjetVoli(string objetid, string type, string description, string lieuStock,  int montant, int hauteur, int largeur, int longueur, string etat) :base(objetid, type, description,etat, lieuStock, montant)
        {
            base.Vendu = false;
            this.Hauteur = hauteur;
            this.Largeur = largeur;
            this.Longueur = longueur;
        }

        public int Hauteur { get => hauteur; set => hauteur = value; }
        public int Largeur { get => largeur; set => largeur = value; }
        public int Longueur { get => longueur; set => longueur = value; }
        public new int Volume { get => longueur*Hauteur*Largeur; }
    }
}
