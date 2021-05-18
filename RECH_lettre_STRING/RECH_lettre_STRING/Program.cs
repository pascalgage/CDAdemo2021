using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECH_lettre_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            string maphrase;
            char lettre;

            int compteur = 0;

            Console.WriteLine("Entrez une phrase terminée par un point:");
            maphrase = Console.ReadLine();

            Console.WriteLine("Entrez la lettre recherchée:");
            char.TryParse(Console.ReadLine(), out lettre);

            for (int i = 0; i < maphrase.Length; i++)
            {
                if (maphrase[i]==lettre)
                {
                    compteur++;
                }
            }
            if (compteur == 0)
            {
                Console.WriteLine("La lettre "+lettre+" n'est pas présente");
            }
            else
            {
                Console.WriteLine("La lettre " + lettre + " apparaît : " + compteur + " fois dans la phrase");
            }
            

            Console.ReadKey();
        }
    }
}
