﻿using ClassPREMIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PREMIER_LIST
{
    public class Program
    {
        static void Main(string[] args)
        {
            uint nb;
            

            Console.WriteLine("Entrez la fourchette de premiers entre 0 et : ");
            nb = uint.Parse(Console.ReadLine());

            List<uint> r = Class1.DonneLesPremiers(nb);
            Console.WriteLine("Les nombres premiers compris entre 0 et " + nb + " sont:");
            for (int i = 0; i < r.Count; i++)
            {
                Console.WriteLine(r[i]);
            }
            

            Console.ReadKey();

        }
        
        
        
    }
}
