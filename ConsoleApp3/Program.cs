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
                        bool fin2 = false;
                        bool valid2 = true;
                        string lecture2 = "";

                        //Menu interactif
                        //---------------
                        do
                        {
                            fin2 = false;
                            //
                            Console.WriteLine();
                            Console.WriteLine("1 : Création d'un don");
                            Console.WriteLine("2 : Stockage d'un don");
                            Console.WriteLine("3 : Transfert d'un don");
                            Console.WriteLine("4 : Archiver un don");
                            Console.WriteLine("5 : Sortir de ce module");
                            //
                            do
                            {
                                lecture2 = "";
                                valid2 = true;

                                Console.Write("\nchoisissez un programme > ");
                                lecture2 = Console.ReadLine();
                                Console.WriteLine(lecture2);
                                if (lecture2 == "" || !"12345".Contains(lecture2[0]))
                                {
                                    Console.WriteLine("votre choix <" + lecture2 + "> n'est pas valide = > recommencez ");
                                    valid2 = false;
                                }
                            } while (!valid2);
                            //
                            //
                            switch (lecture2[0])
                            { 
                                case '1':
                                    Console.Clear();
                                    string datereception, typeMat, descSupp;
                                    bool Accepter;
                                    Objet newobjet;
                                    bool stocker;
                                    string MembreAssoID, objetid, type, description, état, lieuStock;
                                    int montant = 0;
                                    Console.Clear();

                                    Console.WriteLine(" Entrez votre identifiant personnel : ");
                                    MembreAssoID = Console.ReadLine();
                                    // pas d'information concernant la gestion des id des objets
                                    Console.Clear();

                                    Console.WriteLine(" Entrez l'id de l'objet : ");
                                    objetid = Console.ReadLine();

                                    // string dateRecept, string typeMat, string descSupp, bool Accepter, Objet objet, bool stocker, string MembreAssoID
                                    // string objetid, string type, string description, string état, string lieuStock, int montant
                                    Console.Clear();

                                    Console.WriteLine(" Entrez la date de reception du don au format jour/mois/année : ");
                                    datereception = Console.ReadLine();
                                    Console.Clear();

                                    Console.WriteLine(" Entrez le type de materiaux : ");
                                    typeMat = Console.ReadLine();
                                    Console.Clear();

                                    Console.WriteLine(" Entrez l'état du don : ");
                                    état = Console.ReadLine();



                                    bool valid5 = true;
                                    string lecture5 = "";

                                    Console.WriteLine();
                                    Console.WriteLine("Acceptez-vous ce don ? ");
                                    Console.WriteLine("1 : oui");
                                    Console.WriteLine("2 : non");

                                    //
                                    do
                                    {
                                        lecture5 = "";
                                        valid5 = true;

                                        Console.Write("\nchoisissez un programme > ");
                                        lecture5 = Console.ReadLine();
                                        Console.WriteLine(lecture5);
                                        if (lecture5 == "" || !"1234".Contains(lecture5[0]))
                                        {
                                            Console.WriteLine("votre choix <" + lecture5 + "> n'est pas valide = > recommencez ");
                                            valid5 = false;
                                        }
                                    } while (!valid5);
                                    //
                                    //
                                    switch (lecture5[0])
                                    {
                                        case '1':
                                            Console.Clear();
                                            Accepter = true;
                                            break;
                                        case '2':
                                            Console.Clear();
                                            Accepter = false;
                                            break;



                                        default:
                                            Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                            break;
                                    }



                                    Console.WriteLine();
                                    Console.WriteLine("Souhaitez-vous le stocker ? ");
                                    Console.WriteLine("1 : oui");
                                    Console.WriteLine("2 : non");
                                    bool valid6 = true;
                                    string lecture6 = "";
                                    //
                                    do
                                    {
                                        lecture6 = "";
                                        valid6 = true;

                                        Console.Write("\nchoisissez un programme > ");
                                        lecture6 = Console.ReadLine();
                                        Console.WriteLine(lecture6);
                                        if (lecture6 == "" || !"1234".Contains(lecture6[0]))
                                        {
                                            Console.WriteLine("votre choix <" + lecture6 + "> n'est pas valide = > recommencez ");
                                            valid6 = false;
                                        }
                                    } while (!valid6);
                                    //
                                    //
                                    switch (lecture6[0])
                                    {
                                        case '1':
                                            Console.Clear();
                                            stocker = true;
                                            break;
                                        case '2':
                                            Console.Clear();
                                            stocker = false;
                                            break;



                                        default:
                                            Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                            break;
                                    }
                                    typeMat = Console.ReadLine();


                                    bool fin3 = false;
                                    bool valid3 = true;
                                    string lecture3 = "";

                                    //Menu interactif
                                    //---------------
                                    do
                                    {
                                        fin3 = false;
                                        //
                                        Console.WriteLine(" Entrez quel type d'objet est le don : ");
                                        Console.WriteLine("1 : Mobilier Chambre");
                                        Console.WriteLine("2 : Mobilier Salle ou Cuisine");
                                        Console.WriteLine("3 : Electro-ménager");
                                        Console.WriteLine("4 : Vaisselle");
                                        Console.WriteLine("5 : Autre");
                                       
                                        //
                                        do
                                        {
                                            lecture3 = "";
                                            valid3 = true;

                                            Console.Write("\nchoisissez un programme > ");
                                            lecture3 = Console.ReadLine();
                                            Console.WriteLine(lecture3);
                                            if (lecture3 == "" || !"12345".Contains(lecture3[0]))
                                            {
                                                Console.WriteLine("votre choix <" + lecture3 + "> n'est pas valide = > recommencez ");
                                                valid3 = false;
                                            }
                                        } while (!valid3);
                                        //
                                        //
                                        switch (lecture3[0])
                                        {
                                            case '1':
                                                Console.Clear();
                                                bool fin4 = false;
                                                bool valid4 = true;
                                                string lecture4 = "";

                                                //Menu interactif
                                                //---------------
                                                do
                                                {
                                                    fin4 = false;
                                                    //
                                                    Console.WriteLine();
                                                    Console.WriteLine("1 : Un matelas");
                                                    Console.WriteLine("2 : Un chevet");
                                                    Console.WriteLine("3 : Une armoire");

                                                    //
                                                    do
                                                    {
                                                        lecture4 = "";
                                                        valid4 = true;

                                                        Console.Write("\nchoisissez un objet > ");
                                                        lecture4 = Console.ReadLine();
                                                        Console.WriteLine(lecture4);
                                                        if (lecture4 == "" || !"123".Contains(lecture4[0]))
                                                        {
                                                            Console.WriteLine("votre choix <" + lecture4 + "> n'est pas valide = > recommencez ");
                                                            valid4 = false;
                                                        }
                                                    } while (!valid4);
                                                    //
                                                    //
                                                    switch (lecture4[0])
                                                    {
                                                        case '1':
                                                            Console.Clear();
                                                            
                                                            break;
                                                        case '2':
                                                            Console.Clear();
                                                            break;
                                                        case '3':
                                                            Console.Clear();
                                                            break;                                                           
                                                        default:
                                                            Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                                            break;
                                                    }
                                                } while (!fin4);
                                                break;
                                            case '2':
                                                Console.Clear();

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

                                            default:
                                                Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                                break;
                                        }
                                    } while (!fin3);
                                    Console.WriteLine(" Entrez une description plus détaillé du don : ");
                                    descSupp = Console.ReadLine();
                                    Console.WriteLine("Ou souhaitez vous le stocker ? ");
                                    bool valid7 = true;
                                    string lecture7 = "";

                                    Console.WriteLine();

                                    Console.WriteLine("1 : Garde Meuble");
                                    Console.WriteLine("2 : Dépot Vente");
                                    Console.WriteLine("3 : Association");

                                    //
                                    do
                                    {
                                        lecture7 = "";
                                        valid7 = true;

                                        Console.Write("\nchoisissez un programme > ");
                                        lecture7 = Console.ReadLine();
                                        Console.WriteLine(lecture7);
                                        if (lecture7 == "" || !"123".Contains(lecture7[0]))
                                        {
                                            Console.WriteLine("votre choix <" + lecture7 + "> n'est pas valide = > recommencez ");
                                            valid7 = false;
                                        }
                                    } while (!valid7);
                                    //
                                    //
                                    switch (lecture7[0])
                                    {
                                        case '1':
                                            Console.Clear();

                                            break;
                                        case '2':
                                            Console.Clear();

                                            break;
                                        case '3':
                                            Console.Clear();

                                            break;
                                        default:
                                            Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                            break;
                                    }




                                    break;
                                case '2':
                                    Console.Clear();

                                    break;
                                case '3':
                                    Console.Clear();

                                    break;
                                case '4':
                                    Console.Clear();

                                    break;
                                case '5':
                                    Console.Clear();
                                    fin2 = true;
                                    break;
                                default:
                                    Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                    break;
                            }
                        } while (!fin2);
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

