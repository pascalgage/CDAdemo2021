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
            //On invite l'utilisateur a entrer un nombre entier positif
            uint nbr;
            Console.WriteLine("Entrez un nombre entier positif:");
            nbr = uint.Parse(Console.ReadLine());

            //Création le la liste des diviseurs du Nombre NBR....

            List<uint> r = Diviseur1.Diviseur(nbr);

            //Traitement du nombre NBR...affichage premier oui/non ou les diviseurs

            if (Diviseur1.EstUnNombrepremier(nbr) == true)
            {
                Console.WriteLine(+nbr + " est premier donc les diviseurs sont 1 et lui-même");
            }
            else
            {
                Console.WriteLine("Les diviseurs de " + nbr + " sont:");

                for (int i = 0; i < r.Count; i++)
                {
                    Console.WriteLine(r[i]);
                }
            }

            Console.ReadKey();

        }
        
    }
}
