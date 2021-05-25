using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dichotomie
{
    class Program
    {
        static void Main(string[] args)
        {
            string prenom="";
            string prenomRecherché;

            List<string> prenoms = new List<string>();

            TabCreation.CreeTab(out prenoms);

            for (int i = 0; i < prenoms.Count; i++)
            {
                Console.WriteLine(prenoms[i]);
            }

            Console.WriteLine("Entrez le prénom que vous recherchez pour obtenir son index:");
            prenomRecherché = Console.ReadLine();

            int milieu = 0;
            int debut = 0;
            int fin = 0;

            
            


            //for (int i = 0; i < prenoms.Count; i++)
            //{
            //    if (prenomRecherché == prenoms[i])
            //    {
            //        Console.WriteLine("Le prénom recherché "+prenomRecherché+" est à la position " +(i+1));

            //    }


            //}

            Console.ReadKey();
        }
    }
}
