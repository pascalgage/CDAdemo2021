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
            int nbreleve = 1;
            int compteur = 0;
            string Xeleve = "";

            int ind = 1;
           

            Console.WriteLine("Entrez le nombre d'élèves de votre liste:");
            nbreleve = int.Parse(Console.ReadLine());


            do
            {
                do
                {
                    Console.WriteLine("Veuillez entrer les prénoms des vos "+(ind++)+"/" + nbreleve + " élève(s):");
                    break;
                }
                while (ind != nbreleve);



                while ((prenom = Console.ReadLine()) != null)
                {
                    prenoms.Add(prenom);
                    compteur++;
                    break;
                }

            } while (compteur != nbreleve);

            Console.WriteLine("Entrez le prénom recherché:");
            Xeleve = Console.ReadLine();

            Console.WriteLine(Class1.Search_inTab(prenoms, Xeleve));

            Console.ReadKey();
        }
    }
}
