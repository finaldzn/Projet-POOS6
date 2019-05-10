﻿using System;
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
                            Console.WriteLine("2 : Rechercher selon téléphone ou nom");
                            Console.WriteLine("3 : Sortir de ce module");
                            //
                            do
                            {
                                lecture1 = "";
                                valid1 = true;

                                Console.Write("\nchoisissez un programme > ");
                                lecture1 = Console.ReadLine();
                                Console.WriteLine(lecture1);
                                if (lecture1 == "" || !"123".Contains(lecture1[0]))
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
                                    Objet objet;
                                    bool stocker;
                                    string MembreAssoID, objetid, type, description, état, lieuStock;
                                    int montant;
                                    Console.WriteLine(" Entrez la date de reception du don au format jour/mois/année : ");
                                    datereception = Console.ReadLine();
                                    Console.WriteLine(" Entrez le type de materiaux : ");
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
                                       
                                        //
                                        do
                                        {
                                            lecture3 = "";
                                            valid3 = true;

                                            Console.Write("\nchoisissez un programme > ");
                                            lecture3 = Console.ReadLine();
                                            Console.WriteLine(lecture3);
                                            if (lecture3 == "" || !"1234".Contains(lecture3[0]))
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
                                            case '6':
                                                Console.Clear();
                                                Console.WriteLine("fin de programme...");
                                                Console.ReadKey();
                                                fin3 = true;
                                                break;
                                            default:
                                                Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                                break;
                                        }
                                    } while (!fin3);
                                    Console.WriteLine(" Entrez une description plus détaillé du don : ");
                                    descSupp = Console.ReadLine();
                                    Console.WriteLine(" Entrez votre identifiant personnel : ");
                                    MembreAssoID = Console.ReadLine();
                                    // pas d'information concernant la gestion des id des objets
                                    Console.WriteLine(" Entrez l'id de l'objet : ");
                                    objetid = Console.ReadLine();

                                    // string dateRecept, string typeMat, string descSupp, bool Accepter, Objet objet, bool stocker, string MembreAssoID
                                    // string objetid, string type, string description, string état, string lieuStock, int montant



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

