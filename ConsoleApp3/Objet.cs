using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Objet
    {
        protected string objetid, Type, Description, LieuStock;
        Beneficiaire benef;
        int Montant;
        bool vendu;
        string état;

        public Objet(string objetid, string type, string description, string état, string lieuStock, int montant)
        {
            this.état = état;
            this.Objetid = objetid;
            this.Type = type;
            Description1 = description;
            LieuStock1 = lieuStock;
            this.Vendu = false;
            Montant1 = montant;
        }
        /// <summary>
        /// a appeler lorsque l'on souhaite vendre ou donner un objet
        /// </summary>
        /// <param name="benef"></param>
        public void vendre(Beneficiaire benef)
        {
            this.Benef = benef;
            this.Vendu = true;
        }
        public string Objetid { get => objetid; set => objetid = value; }
        public string Type1 { get => Type;  }
        public string Etat { get => état; }
        public string Description1 { get => Description; set => Description = value; }
        public string LieuStock1 { get => LieuStock; set => LieuStock = value; }
        public int Montant1 { get => Montant; set => Montant = value; }
        public Beneficiaire Benef { get => benef; set => benef = value; }
        public bool Vendu { get => vendu; set => vendu = value; }
        public int Volume { get => 0; }
    }
}
