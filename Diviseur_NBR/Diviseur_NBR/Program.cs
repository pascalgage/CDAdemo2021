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
            uint NBR;
            Console.WriteLine("Entrez un nombre entier:");
            NBR = uint.Parse(Console.ReadLine());


            List<uint> r = Diviseur1.Diviseur(NBR);

            Console.WriteLine("Les diviseurs de " + NBR + " sont:");

            for (int i = 0; i < r.Count; i++)
            {
                Console.WriteLine(r[i]);
            }

            if (Diviseur1.EstUnNombrepremier(NBR) == true)
            {
                Console.WriteLine(+NBR + " est premier donc les diviseurs sont 1 et lui-même");
            }



            Console.ReadKey();

        }
        
    }
}
