using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diviseur_NBR
{
    class Program
    {
        static void Main(string[] args)
        {
            int NBR;
            Console.WriteLine("Entrez un nombre entier:");
            NBR = int.Parse(Console.ReadLine());

            List<int> r= Diviseur(NBR);

            Console.WriteLine("Les diviseurs de " + NBR + " sont:");

            for (int i = 0; i < r.Count; i++)
            {
                Console.WriteLine(r[i]);
            }

            Console.ReadKey();

        }
        public static List<int> Diviseur(int _nbr)
        {
            int diviseur = 2;
            List<int> Listing = new List<int>();

            do
            {
                if (_nbr % diviseur == 0)
                {
                    Listing.Add(diviseur);
                }
                diviseur++;

            } while (diviseur < _nbr);

            return Listing;
        }
    }
}
