﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
    class Program
    {
        static void Main(string[] args)
        {
            //decimal aRajouterEnPourcentage=10;

            Bouteille mabouteille;
            mabouteille = new Bouteille();

            mabouteille.Ouvrir();
            mabouteille.Remplir(10);
            mabouteille.RemplirTout();
            mabouteille.Vider(30);
            mabouteille.ViderTout();

            Console.WriteLine(mabouteille.ToString());

            Console.ReadKey();
        }
    }
}
