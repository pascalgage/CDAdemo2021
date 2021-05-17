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
            Console.WriteLine("Entrez un nombre entier positif:");
            NBR = uint.Parse(Console.ReadLine());

            //Création le la liste des diviseurs du Nombre NBR....

            List<uint> r = Diviseur1.Diviseur(NBR);

            //Traitement du nombre NBR...affichage premier oui/non ou les diviseurs

            if (Diviseur1.EstUnNombrepremier(NBR) == true)
            {
                Console.WriteLine(+NBR + " est premier donc les diviseurs sont 1 et lui-même");
            }
            else
            {
                Console.WriteLine("Les diviseurs de " + NBR + " sont:");

                for (int i = 0; i < r.Count; i++)
                {
                    Console.WriteLine(r[i]);
                }
            }

            Console.ReadKey();

        }
        
    }
}
