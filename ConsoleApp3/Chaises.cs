﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Chaises : MobilierSalleCuisine
    {
        public Chaises(string objetid, string Type, string description, string lieuStock, int montant, string état) : base(objetid, Type, description, lieuStock, montant,état)
        {
            this.Description = "Chaise";
        }
    }
}
