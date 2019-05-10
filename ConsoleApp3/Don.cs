using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Don
    {
        string dateRecept, TypeMat, objetID, descSupp;
        MembreAsso Donateur;
        bool Accepter;
        bool stocker;
        Objet objet;
        

        public Don(string dateRecept, string typeMat, string descSupp, MembreAsso donateur, bool Accepter, Objet objet)
        {
            this.DateRecept = dateRecept;
            TypeMat1 = typeMat;
            this.ObjetID = objet.Objetid;
            this.DescSupp = descSupp;
            Donateur1 = donateur;
            this.Accepter1 = Accepter;
            Stocker = false;
            this.Objet = objet;
        }
        public Don(string dateRecept, string typeMat ,string descSupp, MembreAsso donateur, bool Accepter, Objet objet, bool stocker)
        {
            this.DateRecept = dateRecept;
            TypeMat1 = typeMat;
            this.ObjetID = objetID;
            this.DescSupp = descSupp;
            Donateur1 = donateur;
            this.Accepter1 = Accepter;
            this.Stocker = stocker;
            this.Objet = objet;
        }
        
        public string DateRecept { get => dateRecept; set => dateRecept = value; }
        public string TypeMat1 { get => TypeMat; set => TypeMat = value; }
        public string ObjetID { get => objetID; set => objetID = value; }
        public string DescSupp { get => descSupp; set => descSupp = value; }
        public MembreAsso Donateur1 { get => Donateur; set => Donateur = value; }
        public bool Accepter1 { get => Accepter; set => Accepter = value; }
        public bool Stocker { get => stocker; set => stocker = value; }

        internal Objet Objet
        {
            get => objet;
            set
            {
                objet = value;
            }
        }




        /// <summary>
        /// où l'objet doit être stocké
        /// </summary>
        /// <param name="endroit">lieu de stock</param>
        public void Stockage(string endroit)
        {
            Objet.LieuStock1 = endroit;
        }
        public override string ToString()
        {
            return DateRecept+";"+TypeMat1+";"+";"+ObjetID+";"+DescSupp+";"+Accepter1+";"+Donateur1.ToString();
        }

    }
}
