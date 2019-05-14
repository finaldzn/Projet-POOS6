using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Association association = new Association();
            association.Peupler();

            /* Console.WriteLine(association.getmoyAge());

           

             Objet objet = new Objet("1", "Salon", "chaise rouge","neuf", "Association", 0);
             association.NouveauDon("01/05/2019", "chaise", "chaise rouge", true, objet,true,"1");
             Console.WriteLine(association.Stockage.getEnAttente()[0]);*/
            bool fin = false;
            bool valid = true;
            string lecture = "";

            //Menu interactif
            //---------------
            do
            {
                fin = false;
                //
                Console.WriteLine();
                Console.WriteLine("1 : Module Personne");
                Console.WriteLine("2 : Module dons");
                Console.WriteLine("3 : Module tris");
                Console.WriteLine("4 : Module statistique");
                Console.WriteLine("5 : Module autre");
                Console.WriteLine("6 : fin");
                //
                do
                {
                    lecture = "";
                    valid = true;

                    Console.Write("\nchoisissez un programme > ");
                    lecture = Console.ReadLine();
                    Console.WriteLine(lecture);
                    if (lecture == "" || !"123456".Contains(lecture[0]))
                    {
                        Console.WriteLine("votre choix <" + lecture + "> n'est pas valide = > recommencez ");
                        valid = false;
                    }
                } while (!valid);
                //
                //
                switch (lecture[0])
                {
                    case '1':
                        Console.Clear();

                        bool fin1 = false;
                        bool valid1 = true;
                        string lecture1 = "";

                        do
                        {
                            fin1 = false;
                            //
                            Console.WriteLine();
                            Console.WriteLine("1 : Lire les Personnes de l'association");
                            Console.WriteLine("2 : Rechercher un beneficiaire selon téléphone ou nom");
                            Console.WriteLine("3 : Supprimer un beneficiaire");
                            Console.WriteLine("4 : Sortir de ce module");
                            //
                            do
                            {
                                lecture1 = "";
                                valid1 = true;

                                Console.Write("\nchoisissez un programme > ");
                                lecture1 = Console.ReadLine();
                                Console.WriteLine(lecture1);
                                if (lecture1 == "" || !"1234".Contains(lecture1[0]))
                                {
                                    Console.WriteLine("votre choix <" + lecture1 + "> n'est pas valide = > recommencez ");
                                    valid1 = false;
                                }
                            } while (!valid1);
                            //
                            //
                            switch (lecture1[0])
                            {
                                case '1':
                                    Console.Clear();
                                    association.Lirepersonne();
                                    break;
                                case '2':
                                    Console.Clear();
                                    string entrée;
                                    Console.WriteLine("Entrez un numéro de téléphone ou un nom ");
                                    entrée = Console.ReadLine();
                                    Console.WriteLine(association.findName(entrée));
                                    Console.WriteLine(association.findPhone(entrée));
                                    if(association.findPhone(entrée) == null && association.findName(entrée) == null)
                                    {
                                        Console.WriteLine("Aucune personne ne correspond à ce nom ou numéro de téléphone");
                                    }                                  
                                    break;
                                case '3':
                                    Console.Clear();
                                    association.SupprimerBeneficiaire();
                                    break;
                                case '4':
                                    Console.Clear();
                                    fin1 = true;
                                    break;
                                default:
                                    Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                    break;
                            }
                        } while (!fin1);

                        break;
                    case '2':

                        Console.Clear();
                        Console.WriteLine("Voici les objets en attente : ");
                        List<Don> attente = association.Stockage.getEnAttente();
                        foreach (Don elem in attente)
                        {
                            Console.WriteLine(elem);
                        }
                        Console.WriteLine("Entrer le donID du don que vous souhaitez bougez");
                        string objetID = Console.ReadLine();
                        Console.WriteLine("Où souhaitez vous le stocker ? 1:Depot Vente, 2:Gardemeuble, 3:Je ne veux plus le bouger");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Entrer le Montant : ");
                                string montant = Console.ReadLine();
                                association.Stockage.BougezDon(objetID, Int32.Parse(montant));
                                break;
                            case "2":
                                Console.WriteLine("Entrer le Nom du benificiaire : ");
                                Dictionary<string, Beneficiaire> benificaires = association.Benificaires;
                                foreach (KeyValuePair<string, Beneficiaire> elm in benificaires)
                                {
                                    Console.WriteLine(elm.Value);
                                }
                                string name = Console.ReadLine();
                                Beneficiaire a = association.findName(name);
                                association.Stockage.BougezDon(objetID, a);
                                break;
                            case "3":
                                break;
                        }

                        break;
                    case '3':
                        Console.Clear();

                        break;
                    case '4':
                        Console.Clear();

                        break;
                    case '5':
                        Console.Clear();

                        break;
                    case '6':
                        Console.Clear();
                        Console.WriteLine("fin de programme...");
                        Console.ReadKey();
                        fin = true;
                        break;
                    default:
                        Console.WriteLine("\nchoix non valide => faites un autre choix....");
                        break;
                }
            } while (!fin);

        }
    }
}

