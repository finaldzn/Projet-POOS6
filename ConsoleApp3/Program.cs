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
<<<<<<< HEAD

=======
            MembreAsso donnateur = new MembreAsso("1", "Blabla", "chris", "3hkefh", "0655214", "donnateur");
            Objet ok = new Objet("42", "Salon", "Table", "bien", "Garde Meuble", 0);
            association.NouveauDon("12/05/2015", "bois", "bois", true, ok, true, "1");
            Objet ok1 = new Objet("22", "Salon", "chaise", "bien", "Garde Meuble", 0);
            association.NouveauDon("12/06/2015", "bois", "bois", true, ok1, true, "1");
            Objet ok2 = new Objet("2", "Salon", "frigo", "bien", "Garde Meuble", 0);
            association.NouveauDon("13/05/2015", "bois", "bois", false, ok2, true, "1");
            Objet ok3 = new Objet("44", "Salon", "meuble", "bien", "Garde Meuble", 0);
            association.NouveauDon("2/05/2015", "bois", "bois", true, ok3, true, "5");
            Objet ok4 = new Objet("52", "Salon", "armoire", "bien", "Garde Meuble", 0);
            association.NouveauDon("16/05/2015", "bois", "bois", false, ok4, true, "2");
            Objet ok5 = new Objet("66", "Salon", "cuisiniere", "bien", "Garde Meuble", 0);
            association.NouveauDon("25/05/2015", "bois", "bois", true, ok5, false, "2");
            Objet ok6 = new Objet("90", "Cuisine", "Meuble", "très bien", "Depot Vente", 10);
            association.NouveauDon("10/02/2016", "metal", "Blanc", true, ok6, true, "1");
            Objet ok7 = new Objet("76", "Toilette", "Chaise", "bien", "Garde Meuble", 0);
            association.NouveauDon("19/03/2016", "bois", "bois", true, ok7, true, "2");
            Objet ok8 = new Objet("07", "Cuisine", "Plaques", "moyen", "Garde Meuble", 0);
            association.NouveauDon("10/03/2016", "metal", "Blanc", true, ok8, true, "3");
            Objet ok9 = new Objet("09", "Cuisine", "Meuble", "bien", "Depot Vente", 10);
            association.NouveauDon("11/09/2016", "metal", "Blanc", true, ok9, true, "1");
            association.Stockage.BougezDon("09", 10);
            association.Stockage.BougezDon("07", 15);
            association.Stockage.BougezDon("90", 40);
>>>>>>> 16fb3ebe0faedfe1e2120fc985b24febd299fc99
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
                            Console.WriteLine("2 : Transfert d'un don");
                            Console.WriteLine("3 : Archiver un don");
                            Console.WriteLine("4 : Sortir de ce module");
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
                                    bool Accepter = false;
                                    Objet newobjet = null;
                                    bool stocker = false;
                                    string MembreAssoID = "";
                                    string objetid = "";
                                    string type = "";
                                    string description = "";
                                    string état = "";
                                    string lieuStock = "association";
                                    double montant = 0;
                                    
                                    Console.Clear();

                                    Console.WriteLine(" Entrez l'identifiant personnel du donnateur : ");
                                    association.Lirepersonnel();
                                    MembreAssoID = Console.ReadLine();
                                    MembreAsso personnel = association.Personnel[MembreAssoID];
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
                                    Console.Clear();



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
                                        if (lecture5 == "" || !"12".Contains(lecture5[0]))
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
                                        if (lecture6 == "" || !"12".Contains(lecture6[0]))
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

                                   
                                    Console.WriteLine(" Entrez une description plus détaillé du don : ");
                                    descSupp = Console.ReadLine();

                                    bool fin3 = false;
                                    bool valid3 = true;
                                    string lecture3 = "";
                                    Console.Clear();
                                    //Menu interactif
                                    //---------------
                                  
                                        fin3 = false;
                                        //

                                       
                                        //
                                        do
                                        {
                                            lecture3 = "";
                                            valid3 = true;
                                            Console.WriteLine(" Entrez quel type d'objet est le don : ");
                                            Console.WriteLine("1 : Mobilier Chambre");
                                            Console.WriteLine("2 : Mobilier Salle ou Cuisine");
                                            Console.WriteLine("3 : Electro-ménager");
                                            Console.WriteLine("4 : Vaisselle");
                                            Console.WriteLine("5 : Objet Volumineux");
                                            Console.WriteLine("6 : Autre");
                                            Console.Write("\nchoisissez un programme > ");
                                            lecture3 = Console.ReadLine();
                                            Console.WriteLine(lecture3);
                                            if (lecture3 == "" || !"123456".Contains(lecture3[0]))
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
                                                            newobjet = new Matelas(objetid, "Chambre", "Matelas", lieuStock, 0, état);
                                                            fin4 = true;
                                                            break;
                                                        case '2':
                                                            Console.Clear();
                                                            newobjet = new Chevets(objetid, "Chambre", "Chevet", lieuStock, 0, état);
                                                            fin4 = true;
                                                            break;
                                                        case '3':
                                                            Console.Clear();
                                                            newobjet = new Armoires(objetid, "Chambre", "Armoire", lieuStock, 0, état);
                                                            fin4 = true;
                                                            break;                                                           
                                                        default:
                                                            Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                                            break;
                                                    }
                                                } while (!fin4);
                                                break;
                                            case '2':
                                                Console.Clear();
                                                fin4 = false;
                                                valid4 = true;
                                                lecture4 = "";

                                                //Menu interactif
                                                //---------------
                                                do
                                                {
                                                    fin4 = false;
                                                    //
                                                    Console.WriteLine();
                                                    Console.WriteLine("1 : Une table");
                                                    Console.WriteLine("2 : Une chaise");
                                                    //
                                                    do
                                                    {
                                                        lecture4 = "";
                                                        valid4 = true;

                                                        Console.Write("\nchoisissez un objet > ");
                                                        lecture4 = Console.ReadLine();
                                                        Console.WriteLine(lecture4);
                                                        if (lecture4 == "" || !"12".Contains(lecture4[0]))
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
                                                            Console.WriteLine("De quelle forme est cette table ? ");
                                                            string forme = Console.ReadLine();
                                                            Console.Clear();
                                                            Console.WriteLine("Est ce une table pour les salons ou pour les cuisines ? ");
                                                            string type2 = Console.ReadLine();
                                                            
                                                            newobjet = new Table(objetid,type2, "Table",forme, lieuStock, 0, état);
                                                            fin4 = true;
                                                            break;
                                                        case '2':                                                            
                                                            Console.Clear();
                                                            Console.WriteLine("Est ce une chaise pour les salons ou pour les cuisines ? ");
                                                            type2 = Console.ReadLine();
                                                            newobjet = new Chaises(objetid,type2, "Chaise", lieuStock, 0, état);
                                                            fin4 = true;
                                                            break;
                                                        
                                                        default:
                                                            Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                                            break;
                                                    }
                                                } while (!fin4);

                                                break;
                                            case '3':
                                                Console.Clear();
                                                fin4 = false;
                                                valid4 = true;
                                                lecture4 = "";

                                                //Menu interactif
                                                //---------------
                                                do
                                                {
                                                    fin4 = false;
                                                    //
                                                    Console.WriteLine();
                                                    Console.WriteLine("1 : Une Cuisinière");
                                                    Console.WriteLine("2 : Un Refrégirateur");
                                                    Console.WriteLine("3 : Un lave-linge");
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
                                                            Console.WriteLine("Quelle est la puissance de cette cuisinière ? ");
                                                            int puissance = Convert.ToInt32(Console.ReadLine());
                                                            Console.Clear();
                                                            Console.WriteLine("Combien de plaques a cette cuisinière ? ");
                                                            int nb_plaque = Convert.ToInt32(Console.ReadLine());
                                                            newobjet = new Cuisinière(objetid, "Cuisine", "Cuisinière",puissance,nb_plaque, lieuStock, 0, état);
                                                            fin4 = true;
                                                            break;
                                                        case '2':
                                                            Console.Clear();
                                                            newobjet = new Réfrigérateur(objetid,"Cuisine", "Réfrégirateur", lieuStock, 0, état);
                                                            fin4 = true;
                                                            break;
                                                        case '3':
                                                            Console.Clear();
                                                            newobjet = new Lave_Linge(objetid, "Cuisine", "Lave_linge", lieuStock, 0, état);
                                                            fin4 = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                                            break;
                                                    }
                                                } while (!fin4);
                                                break;
                                            case '4':
                                                Console.Clear();
                                                fin4 = false;
                                                valid4 = true;
                                                lecture4 = "";

                                                //Menu interactif
                                                //---------------
                                                do
                                                {
                                                    fin4 = false;
                                                    //
                                                    Console.WriteLine();
                                                    Console.WriteLine("1 : Des couverts");
                                                    Console.WriteLine("2 : Des assietes");
                                                    //
                                                    do
                                                    {
                                                        lecture4 = "";
                                                        valid4 = true;

                                                        Console.Write("\nchoisissez un objet > ");
                                                        lecture4 = Console.ReadLine();
                                                        Console.WriteLine(lecture4);
                                                        if (lecture4 == "" || !"12".Contains(lecture4[0]))
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
                                                            Console.WriteLine("Quelle est le nombre de pièces ? ");
                                                            int nb_pieces = Convert.ToInt32(Console.ReadLine());                                                           
                                                            newobjet = new Couverts(objetid, "Cuisine", "Couverts", lieuStock, 0, état,nb_pieces);
                                                            fin4 = true;
                                                            break;
                                                        case '2':
                                                            Console.Clear();
                                                            Console.WriteLine("Quelle est le nombre de pièces ? ");
                                                            nb_pieces = Convert.ToInt32(Console.ReadLine());
                                                            newobjet = new Assiettes(objetid, "Cuisine", "Couverts",nb_pieces, lieuStock, 0, état);
                                                            fin4 = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                                            break;
                                                    }
                                                } while (!fin4);
                                                break;

                                            case '5':

                                                Console.Clear();
                                                Console.WriteLine("Pour quelle pièce est fait votre objet ? ");
                                                string piece = Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("Comment s'appelle votre objet ? ");
                                                string nom_objet = Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("Quelle est la hauteur de l'objet ? ");
                                                double hauteur = Convert.ToDouble(Console.ReadLine());
                                                Console.Clear();
                                                Console.WriteLine("Quelle est la longueur de l'objet ? ");
                                                double longueur = Convert.ToDouble(Console.ReadLine());
                                                Console.Clear();
                                                Console.WriteLine("Quelle est la largeur de l'objet ? ");
                                                double largeur = Convert.ToDouble(Console.ReadLine());
                                                Console.Clear();
                                                newobjet = new ObjetVoli(objetid, piece, nom_objet,lieuStock, montant,hauteur,largeur,longueur,état);
                                            break;

                                            case '6':
                                                Console.Clear();
                                                Console.WriteLine("Pour quelle pièce est fait votre objet ? ");
                                                piece = Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("Comment s'appelle votre objet ? ");
                                                nom_objet = Console.ReadLine();
                                                newobjet = new Objet(objetid, piece, nom_objet, état, lieuStock, montant);
                                                break;

                                            default:
                                                Console.WriteLine("\nchoix non valide => faites un autre choix....");
                                                break;
                                        }

                                    Don crea = new Don(datereception, typeMat, descSupp, personnel, Accepter, newobjet);
                                    Console.WriteLine(crea.ToString());                                 
                                    association.NouveauDon(datereception, typeMat, descSupp, Accepter, newobjet, stocker, MembreAssoID);







                                    break;
                                
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Voici les objets en attente : ");
                                    List<Don> attente = association.Stockage.getEnAttente();
                                    foreach (Don elem in attente)
                                    {
                                        Console.WriteLine(elem);
                                    }
                                    Console.WriteLine("Entrer le objetID du don que vous souhaitez bougez");
                                    string objetID = Console.ReadLine();
                                    Console.WriteLine("Où souhaitez vous le stocker ? 1:Depot Vente, 2:Gardemeuble, 3:Je ne veux plus le bouger");
                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            Console.WriteLine("Entrer le Montant : ");
                                            string montant1 = Console.ReadLine();
                                            association.Stockage.BougezDon(objetID, Int32.Parse(montant1));
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
                                    Console.WriteLine("Voici les objets dans le depot vente : ");
                                    List<string> var = association.Stockage.getDepotVente();
                                    foreach (string elem in var)
                                    {
                                        Console.WriteLine(elem);
                                    }
                                    Console.WriteLine("Entrer le objetID du don que vous souhaitez vendre");
                                    objetID = Console.ReadLine();
                                    Console.WriteLine("Entrer la Date : ");
                                    string date = Console.ReadLine();
                                    
                                    Console.WriteLine("Entrer le Nom du benificiaire : ");
                                    Dictionary<string, Beneficiaire> benificaire = association.Benificaires;
                                    foreach (KeyValuePair<string, Beneficiaire> elm in benificaire)
                                    {
                                        Console.WriteLine(elm.Value);
                                    }
                                    string nom = Console.ReadLine();
                                    Beneficiaire benef = association.findName(nom);
                                    association.Stockage.DépotVente.Vendre(date, objetID, benef);

                                    break;
                                case '4':
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
                        Console.WriteLine("Que souhaitez vous regarder ? ");
                        Console.WriteLine("1: Don refusés, triés par date \n2: Don en traitement par ID et Nom \n3: Don vendus/donnés par mois/BenefId \n4: Don stocker différents entrepôts classé par catégorie \n5: Don stocker par Entrepôts et par volume \n6: Dons du dépot-vente ");
                        string value = Console.ReadLine();
                        switch (value)
                        {
                            case "1":
                                List<Don> a = association.Stockage.getRefused();
                                foreach (Don elm in a)
                                {
                                    Console.WriteLine(elm.ToString());
                                }
<<<<<<< HEAD
=======

>>>>>>> 16fb3ebe0faedfe1e2120fc985b24febd299fc99
                                break;
                            case "2":
                                a = association.Stockage.getEnAttente();
                                foreach (Don elm in a)
                                {
                                    Console.WriteLine(elm);
                                }
<<<<<<< HEAD
=======

>>>>>>> 16fb3ebe0faedfe1e2120fc985b24febd299fc99
                                break;
                            case "3":
                                List<string> v = association.Stockage.getSold();
                                foreach (string elm in v)
                                {
                                    Console.WriteLine(elm);
                                }
<<<<<<< HEAD
=======

>>>>>>> 16fb3ebe0faedfe1e2120fc985b24febd299fc99
                                break;
                            case "4":
                                v = association.Stockage.getEntrepotList();
                                foreach (string elm in v)
                                {
                                    Console.WriteLine(elm);
                                }
<<<<<<< HEAD
=======

>>>>>>> 16fb3ebe0faedfe1e2120fc985b24febd299fc99
                                break;
                            case "5":
                                v = association.Stockage.getEntrepotVolumeList();
                                foreach (string elm in v)
                                {
                                    Console.WriteLine(elm);
                                }
<<<<<<< HEAD
=======

>>>>>>> 16fb3ebe0faedfe1e2120fc985b24febd299fc99
                                break;
                            case "6":
                                v = association.Stockage.getDepotVente();
                                foreach (string elm in v)
                                {
                                    Console.WriteLine(elm);
                                }
                                break;
                        }
                        Console.Clear();
                        break;
                    case '4':
                        Console.Clear();

                        break;
                    case '5':

                        Console.Clear();
                        fin = false;
                        valid = true;
                        lecture = "";

                        //Menu interactif
                        //---------------
                        do
                        {
                            fin = false;
                            //
                            Console.WriteLine();
                            Console.WriteLine("1 : Appliquer une promotion");
                            Console.WriteLine("2 : Chercher les objets sous un certain prix");
                            Console.WriteLine("3 : Saisie d'un crime");
                            Console.WriteLine("4 : Le nombre de crimes par quartier et par catégorie");

                            //
                            do
                            {
                                lecture = "";
                                valid = true;

                                Console.Write("\nchoisissez un programme > ");
                                lecture = Console.ReadLine();
                                Console.WriteLine(lecture);
                                if (lecture == "" || !"1234".Contains(lecture[0]))
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
                                    Console.WriteLine("Entrez en % la promotion que vous voulez appliquez : ");
                                    double pourcentage = Convert.ToDouble(Console.ReadLine());
                                    association.Stockage.DépotVente.getPromo(pourcentage);
                                    Console.WriteLine("Promotion appliquée");
                                    break;
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Entrez le prix maximal des objets que vous voulez afficher : ");
                                    double prix = Convert.ToDouble(Console.ReadLine());
                                    association.Stockage.DépotVente.AfficherSelonPrix(prix);
                                    break;
                                case '3':
                                    Console.Clear();

                                    break;

                                case '4':
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

