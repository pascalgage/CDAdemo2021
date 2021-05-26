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
            
            string prenomRecherché;
            string result;

            List<string> prenoms = new List<string>();

            //appel de la méthode CreeTab....cf la classe TabCreation
            TabCreation.CreeTab(out prenoms);

            
            Console.WriteLine("Entrez le prénom que vous recherchez pour obtenir son index:");
            prenomRecherché = Console.ReadLine();

            //appel de la méthode Verif_tableau...cf la classe TabCreation
            result=TabCreation.Verif_tableau(prenoms, prenomRecherché);

            //affichage du résultat
            Console.WriteLine(result);

         
           

            

            Console.ReadKey();
        }
    }
}
