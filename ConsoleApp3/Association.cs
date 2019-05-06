using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Association
    {
        Stockage stockage;
        Dictionary<string, MembreAsso> personnel;
        Dictionary<string, Beneficiaire> benificaires;

        internal Stockage Stockage { get => stockage; set => stockage = value; }
        internal Dictionary<string, MembreAsso> Personnel { get => personnel; set => personnel = value; }
        internal Dictionary<string, Beneficiaire> Benificaires { get => benificaires; set => benificaires = value; }

        public Association()
        {
            Stockage = new Stockage();
            Personnel = new Dictionary<string, MembreAsso>();
            Benificaires = new Dictionary<string, Beneficiaire>();
        }

       

        public void Peupler()
        {
            string[] n = File.ReadAllLines("files/Adherents.txt");
            foreach(string element in n)
            {
                if(element != "")
                {
                    string[] x = element.Split(';');
                    MembreAsso p = new MembreAsso(x[0], x[1], x[4], x[2], x[3], x[5]);
                    Personnel.Add(x[0], p);
                }
                
            }
            n = File.ReadAllLines("files/Beneficiaires.txt");
            foreach(string element in n)
            {
                if(element !="")
                {
                    string[] x = element.Split(';');
                    Beneficiaire p = new Beneficiaire(x[0], x[1], x[4], x[2], x[3], x[5]);
                    Benificaires.Add(x[0], p);
                }
                
            }
        }
        public Beneficiaire findPhone(string phone)
        {
            foreach (KeyValuePair<string,Beneficiaire> elem in Benificaires)
            {
                if(elem.Value.Téléphone == phone)
                {
                    return elem.Value;
                }
            }
            Beneficiaire b = new Beneficiaire();
            return b;
        }
        public Beneficiaire findName(string name)
        {
            foreach (KeyValuePair<string, Beneficiaire> elem in Benificaires)
            {
                if (elem.Value.Nom == name)
                {
                    return elem.Value;
                }
            }
            Beneficiaire b = new Beneficiaire();
            return b;
        }
        public void NouveauDon(string dateRecept, string typeMat, string descSupp, bool Accepter, Objet objet, bool stocker, string MembreAssoID)
        {
            Don var = new Don(dateRecept, typeMat, descSupp, Personnel[MembreAssoID], Accepter, objet);
            Stockage.AddAssociation(var);
            
        }
        //S'occuper des don
        private List<int> decomposerDate(string date)
        {
            List<int> value = new List<int>();
            foreach (string element in date.Split('/'))
            {
                value.Add(int.Parse(element));
            }
            return value;
        }
        #region statistique
        public float getmoyTemps()
        {
            List<string> x = Stockage.getSold();
            float moy = 0;
            foreach(string elem in x)
            {
                List<int> datedep = decomposerDate(elem.Split(';')[1]);
                List<int> dateven = decomposerDate(elem.Split(';')[3]);
                moy += (dateven[0] - datedep[0]) + 31 * (dateven[1] - datedep[1]) + 365 * (dateven[2] - datedep[2]);
            }
            moy = moy / x.Count;
            return moy;
        }
        public float getmoyPrix()
        {
            List<string> x = stockage.getDepotVente();
            float moy = 0;
            foreach(string elem in x)
            {
                moy += float.Parse(elem.Split(';')[2]);
            }
            moy = moy / x.Count;
            return moy;
        }
        public float getmoyAge()
        {
            float moy = 0;
            foreach(KeyValuePair<string,Beneficiaire> elem in benificaires)
            {
                List<int> x = decomposerDate(elem.Value.Dob);
                moy += DateTime.Today.Year - x[2];
            }
            moy = moy / benificaires.Count;
            return moy;
        }
        #endregion
    }
}
