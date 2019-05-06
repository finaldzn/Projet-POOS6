using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IPersonne<T>
    {
        string ToString();
        string Nom { get; set; }
        string Prenom { get; set; }
        string Coordonées { get; set; }
        string Téléphone { get; set; }
        string Identifiant { get; }
    }
}
