﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFizz
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*List<int> nombres = new List<int>();
            

            int nombre=0;
            bool finish = true;
            string decision = "n";

            while (finish==true && decision=="n")
            {
                Console.WriteLine("Entrez vos nombres :");
                nombre = int.Parse(Console.ReadLine());
                nombres.Add(nombre);

                Console.WriteLine("Avez-vous fini votre saisie ?");
                decision = Console.ReadLine();

                if (decision != "n")
                {
                    finish = true;
                    Calcul.Fizzbuzz(nombres);

                }
            }*/

            List<int> nombres = Calcul.KreaList(100);
            Calcul.Fizzbuzz(nombres);
            
            

            Console.ReadKey();
            
            
            
        }
    }
}
