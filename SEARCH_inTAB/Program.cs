using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEARCH_inTAB
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> prenoms = new List<string>();
            string prenom = "";
            int nbreleve = 0;
            int compteur = 0;


            Console.WriteLine("Entrez le nombre d'élève de votre liste:");
            nbreleve = int.Parse(Console.ReadLine());


            do
            {
                Console.WriteLine("Veuillez entrer vos prénoms:");
                while ((prenom = Console.ReadLine()) != null)
                {
                    prenoms.Add(prenom);
                    compteur++;
                    break;
                }

            } while (compteur != nbreleve);

            foreach (string item in prenoms)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
