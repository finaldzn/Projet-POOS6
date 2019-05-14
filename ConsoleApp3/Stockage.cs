using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Stockage
    {
        protected Gardemeuble GardeMeuble;
        protected DepotVente DépotVente;
        protected List<Don> Association;

        public Stockage()
        {
            GardeMeuble = new Gardemeuble();
            DépotVente = new DepotVente();
            Association = new List<Don>();
        }

        internal DepotVente DepotVente
        {
            get => default(DepotVente);
            set
            {
            }
        }

        internal Gardemeuble Gardemeuble
        {
            get => default(Gardemeuble);
            set
            {
            }
        }

        public void AddGardeMeuble( Personne Benificiaire,Don var)
        {
            GardeMeuble.Add(var.DateRecept, Benificiaire, var);
        }
        public void AddDépotVente(int Montant, Don var)
        {
            DépotVente.Add(var.DateRecept, Montant, var);
        }
        public void AddAssociation(Don var)
        {
            Association.Add(var);
        }
        
        /// <summary>
        /// De Association à DépotVente
        /// </summary>
        /// <param name="objetID"></param>
        /// <param name="i"></param>
        /// <param name="montant"></param>
        public void BougezDon(string objetID, int montant)
        {
            Don var = Association.Find(x => x.Objet.Objetid == objetID);                    
            Association.Remove(var);
            AddDépotVente(montant, var);
        }
        /// <summary>
        /// De Association à GardeMeuble
        /// </summary>
        /// <param name="objetID"></param>        
        /// <param name="benef"></param>
        public void BougezDon(string objetID, Beneficiaire benef)
        {
            Don var = Association.Find(x => x.Objet.Objetid == objetID);
            Association.Remove(var);
            AddGardeMeuble(benef, var);
        }
        #region Tris
        /// <summary>
        /// avoir les Don refusé
        /// </summary>
        /// <returns>List de Don</returns>
        public List<Don> getRefused()
        {
            List<Don> result = Association.FindAll(x => x.Accepter1 == false);
            result = result.OrderByDescending(o => o.DateRecept).ToList();
            return result;
        }
        /// <summary>
        /// avoir les Don en attente
        /// </summary>
        /// <returns>Liste de Don</returns>
        public List<Don> getEnAttente()
        {
            
            List<Don> result = Association.OrderBy(o => o.ObjetID).ThenBy(o => o.Donateur1).ToList();
            return result;
        }
        /// <summary>
        /// avoir les don vendus
        /// </summary>
        /// <returns>List de string</returns>
        public List<string> getSold()
        {
            List<string> result = DépotVente.getListSold();
            result.OrderBy(x => x.Split(';')[3]).ThenBy(x => DépotVente.Objets[x.Split(';')[0]].Objet.Benef);
            return result;
        }
        /// <summary>
        /// avoir la liste des objets contenus dans l'entrepots
        /// </summary>
        /// <returns></returns>
        public List<string> getEntrepotList()
        {
            List<string> result = new List<string>();
            foreach (Don elem in Association)
            {
                result.Add(elem.ObjetID + ";" + elem.TypeMat1 + ";" + elem.DescSupp+";Association");
            }
            List<string> x = DépotVente.getListElement();
            foreach(string elem in x)
            {
                result.Add(elem.Split(';')[0] + ";" + DépotVente.Objets[elem.Split(';')[0]].TypeMat1 + ";" + DépotVente.Objets[elem.Split(';')[0]].DescSupp + ";DepotVente");
            }
            x = GardeMeuble.getListElement();
            foreach (string elem in x)
            {
                result.Add(elem.Split(';')[0] + ";" + GardeMeuble.Objets[elem.Split(';')[0]].TypeMat1 + ";" + GardeMeuble.Objets[elem.Split(';')[0]].DescSupp + ";GardeMeuble");
            }
            result.OrderBy(o => o.Split(';')[3]).ThenBy(o => o.Split(';')[1]).ThenBy(o=>o.Split(';')[2]);
            return result;
        }
        /// <summary>
        /// avoir le volume des objets contenus dans l'entrepots
        /// </summary>
        /// <returns></returns>
        public List<string> getEntrepotVolumeList()
        {
            List<string> result = new List<string>();
            foreach (Don elem in Association)
            {
                result.Add(elem.ObjetID + ";" + elem.TypeMat1 + ";" + elem.Objet.Volume+ ";Association");
            }
            List<string> x = DépotVente.getListElement();
            foreach (string elem in x)
            {
                result.Add(elem.Split(';')[0] + ";" + DépotVente.Objets[elem.Split(';')[0]].TypeMat1 + ";" + DépotVente.Objets[elem.Split(';')[0]].Objet.Volume + ";DepotVente");
            }
            x = GardeMeuble.getListElement();
            foreach (string elem in x)
            {
                result.Add(elem.Split(';')[0] + ";" + GardeMeuble.Objets[elem.Split(';')[0]].TypeMat1 + ";" + GardeMeuble.Objets[elem.Split(';')[0]].Objet.Volume + ";GardeMeuble");
            }
            result.OrderBy(o => o.Split(';')[3]).ThenBy(o => o.Split(';')[1]).ThenBy(o => o.Split(';')[2]);
            return result;
        }
        /// <summary>
        /// avoir les Dons contenus dans le depot vente
        /// </summary>
        /// <returns></returns>
        public List<string> getDepotVente()
        {
            List<string> x = DépotVente.getListElement();
            x.OrderBy(o => o.Split(';')[2]);
            return x;
        }
        #endregion

    }



}

