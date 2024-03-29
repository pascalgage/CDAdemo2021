﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCOMPTE;


namespace COMPTE_BANCAIRE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Banque bnp = new Banque("BNP ", " PARIS Xème");
            
            bnp.AjouteCompte(978486, "Pascal", 10000, -100);
            bnp.AjouteCompte(789456, "David", 3000, -100);
            bnp.AjouteCompte(123456, "Doris", 2500, -250);
            Console.WriteLine(bnp);

            if(bnp.Transferer(978486, 123456, 5000))
            {
                Console.WriteLine("Opération effectuée !");
            }
            else
            {
                Console.WriteLine("Opération impossible !");
            }
            if (bnp.Transferer(978486, 123455, 2000))
            {
                Console.WriteLine("Opération effectuée !");
            }
            else
            {
                Console.WriteLine("Opération impossible !");
            }
            bnp.Transferer(123456, 978486, 5000);
            Console.WriteLine(bnp);
            Console.WriteLine(bnp.CompteSup());

            Console.ReadKey();
        }
    }
}
