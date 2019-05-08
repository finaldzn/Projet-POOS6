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
            Console.WriteLine(association.getmoyAge());
            
            Matelas f = new Matelas("joj", "ihz", "sfljzf", "ihfj", 65);
            Console.WriteLine(f.Type1);

            Objet objet = new Objet("1", "chaise", "chaise rouge", "Association", 0);
            association.NouveauDon("01/05/2019", "chaise", "chaise rouge", true, objet,true,"1");
            Console.WriteLine(association.Stockage.getEnAttente()[0]);
            Console.ReadKey();
        }
    }
}
