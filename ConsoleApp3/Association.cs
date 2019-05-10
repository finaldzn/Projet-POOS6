using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    /// <summary>
    /// Classe Association, toutes les fonctionalités sont appelés de cet classe afin d'éviter 
    /// un nombre de fonctions importants dans le main
    /// </summary>
    class Association
    {
        Stockage stockage;
        Dictionary<string, MembreAsso> personnel;
        Dictionary<string, Beneficiaire> benificaires;

        
        internal Dictionary<string, MembreAsso> Personnel { get => personnel; set => personnel = value; }
        internal Dictionary<string, Beneficiaire> Benificaires { get => benificaires; set => benificaires = value; }

        internal Stockage Stockage
        {
            get => stockage; set => stockage = value;
        }

        public Association()
        {
            Stockage = new Stockage();
            Personnel = new Dictionary<string, MembreAsso>();
            Benificaires = new Dictionary<string, Beneficiaire>();
        }

       
        /// <summary>
        /// lis et classe les adhérents et bénificiaire des fichiers
        /// </summary>
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
        public void SupprimerBeneficiaire()
        {
            string sup;
            Console.WriteLine("Entrez le nom du bénéficiaire à supprimer : ");
            sup = Console.ReadLine();
            
            if(findName(sup)!= null)
            {
                Benificaires.Remove(findName(sup).Identifiant);
            }
            else
            {
                Console.WriteLine("Ce beneficiaire n'est pas dans votre association");
            }

        }

        public void Lirepersonne()
        {
            Console.WriteLine("Bénéficiaires : ");
            Console.WriteLine("[ ID | Nom | Adresse | Téléphone | Prénom | Date de naissance ]");
            foreach (KeyValuePair<string, Beneficiaire> elem in Benificaires)
            {

                foreach (string x in elem.ToString().Split(';'))
                {
                    Console.Write(x + " | ");

                }
                Console.WriteLine("");
            }

            Console.WriteLine("Personnels : ");
            Console.WriteLine("[ ID | Nom | Adresse | Téléphone | Prénom | Date de naissance ] ");
            foreach (KeyValuePair<string, MembreAsso> elem in Personnel)
            {
                foreach (string x in elem.ToString().Split(';'))
                {
                    Console.Write(x + " | ");

                }
                Console.WriteLine("");
            }


        }
        /// <summary>
        /// trouve un benificiaire avec un numéro de téléphone spécifique
        /// </summary>
        /// <param name="phone">numéro de téléphone à rechercher</param>
        /// <returns>Le Beneficaire correspondant</returns>
        public Beneficiaire findPhone(string phone)
        {
            foreach (KeyValuePair<string,Beneficiaire> elem in Benificaires)
            {
                if(elem.Value.Téléphone == phone)
                {
                    return elem.Value;
                }
            }
            return null;
        }
        /// <summary>
        /// trouve un benificaire à partir d'un nom
        /// </summary>
        /// <param name="name">nom à rechercher</param>
        /// <returns>Le benificaire correspondant</returns>
        public Beneficiaire findName(string name)
        {
            foreach (KeyValuePair<string, Beneficiaire> elem in Benificaires)
            {
                if (elem.Value.Nom == name)
                {
                    return elem.Value;
                }
            }
            return null;
        }
        /// <summary>
        /// crée un nouveau don
        /// </summary>
        /// <param name="dateRecept"></param>
        /// <param name="typeMat"></param>
        /// <param name="descSupp"></param>
        /// <param name="Accepter"></param>
        /// <param name="objet"></param>
        /// <param name="stocker"></param>
        /// <param name="MembreAssoID"></param>
        public void NouveauDon(string dateRecept, string typeMat, string descSupp, bool Accepter, Objet objet, bool stocker, string MembreAssoID)
        {
            Don var = new Don(dateRecept, typeMat, descSupp, Personnel[MembreAssoID], Accepter, objet);
            Stockage.AddAssociation(var);
            
        }
        
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
        /// <summary>
        /// avoir les stats concernant la moyenne entre les date de dépot et de vente
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// avoir la moy d'âge
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// avoir la moyenne de l'âges des membres
        /// </summary>
        /// <returns></returns>
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
