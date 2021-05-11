using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDiviseur;

namespace Diviseur_NBR
{
    class Program
    {
        static void Main(string[] args)
        {
            int NBR;
            Console.WriteLine("Entrez un nombre entier:");
            NBR = int.Parse(Console.ReadLine());

            List<int> r = Diviseur1.Diviseur(NBR);

            Console.WriteLine("Les diviseurs de " + NBR + " sont:");

            for (int i = 0; i < r.Count; i++)
            {
                Console.WriteLine(r[i]);
            }

            Console.ReadKey();

        }
        
    }
}
