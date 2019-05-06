using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Gardemeuble
    {
        Dictionary<string, string> dateDep ;
        Dictionary<string, string> dateDonné;
        Dictionary<string, Personne> beneficiaire;
        Dictionary<string, Don> objets;

        public Gardemeuble()
        {
            this.DateDep = new Dictionary<string, string>();
            this.DateDonné = new Dictionary<string, string>();
            this.Beneficiaire = new Dictionary<string, Personne>();
            this.Objets = new Dictionary<string, Don>();
        }

        public Dictionary<string, string> DateDep { get => dateDep; set => dateDep = value; }
        public Dictionary<string, string> DateDonné { get => dateDonné; set => dateDonné = value; }
        public Dictionary<string, Personne> Beneficiaire { get => beneficiaire; set => beneficiaire = value; }
        public Dictionary<string, Don> Objets { get => objets; set => objets = value; }
        

        public void Add(string dateDep,Personne beneficiaire, Don objets )
        {
            this.DateDep[objets.Objet.Objetid] = dateDep;
            this.Beneficiaire[objets.Objet.Objetid] = beneficiaire;
            this.Objets[objets.Objet.Objetid] = objets;
        }
        public void Vendre(string date, string objetID, Beneficiaire benef)
        {
            DateDonné[objetID] = date;
            Objets[objetID].Objet.vendre(benef);
        }
        public List<string> getListElement()
        {
            List<string> result = new List<string>();
            foreach (KeyValuePair<string, Don> elem in Objets)
            {
                result.Add(elem.Key + ";" + DateDep[elem.Key]);
            }
            return result;
        }
        public List<string> getListSold()
        {
            List<string> result = new List<string>();
            foreach (KeyValuePair<string, Don> elem in Objets)
            {
                result.Add(elem.Key + ";" + DateDep[elem.Key]+";"+DateDonné[elem.Key]);
            }
            return result;
        }
    }
}
