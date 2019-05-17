using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class DepotVente
    {
        Dictionary<string, string> dateDep;
        Dictionary<string,double> montant;
        Dictionary<string, string> dateVente;
        Dictionary<string,Don> objets;
        double solde;
        public DepotVente()
        {
            DateDep = new Dictionary<string, string>();
            Montant = new Dictionary<string, double>();
            DateVente = new Dictionary<string, string>();
            Objets = new Dictionary<string, Don>();
            solde = 1000;
        }

        private Dictionary<string, string> DateDep { get => dateDep; set => dateDep = value; }
        private Dictionary<string, double> Montant { get => montant; set => montant = value; }
        private Dictionary<string, string> DateVente { get => dateVente; set => dateVente = value; }
        public Dictionary<string, Don> Objets { get => objets; set => objets = value; }
        public double Solde { get => solde; }

        public void getPromo(double pourcentage)
        {
            double promo = pourcentage / 100;
            foreach (KeyValuePair<string, Don> elem in objets)
            {
                Montant[elem.Key] = Montant[elem.Key] - promo *Montant[elem.Key];
            }
        }

        public void AfficherSelonPrix(double prix)
        {
           
            foreach (KeyValuePair<string, Don> elem in objets)
            {
                if(Montant[elem.Key] <= prix)
                {
                    Console.WriteLine(elem.ToString());
                }
            }
            
        }

        public void Add(string dateDep, int montant, Don objet)
        {
            this.DateDep[objet.Objet.Objetid]=dateDep;
            this.Montant[objet.Objet.Objetid] = montant;
            this.Objets[objet.Objet.Objetid] = objet;
        }
        public void Vendre(string date, string ObjetID, Beneficiaire benef)
        {
            this.DateVente[ObjetID] = date;
            Objets[ObjetID].Objet.vendre(benef);
            solde += Montant[ObjetID];
        }
        public List<string> getListSold()
        {
            List<string> result = new List<string>();
            foreach(KeyValuePair<string,Don> elem in Objets)
            {
                result.Add(elem.Key + ";" + DateDep[elem.Key] + ";" + Montant[elem.Key] + ";" + DateVente[elem.Key]);
            }
            return result;
        }
        public List<string> getListElement()
        {
            List<string> result = new List<string>();
            foreach (KeyValuePair<string, Don> elem in Objets)
            {
                result.Add(elem.Key + ";" + DateDep[elem.Key] + ";" + Montant[elem.Key]);
            }
            return result;
        }
    }
}
