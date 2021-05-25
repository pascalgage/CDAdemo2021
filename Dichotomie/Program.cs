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

            bool trouve = false;
            int debut = 1;
            int fin = prenoms.Count;
            int milieu = (debut + fin) / 2;
            do
            {

            
            if (prenomRecherché == prenoms[milieu])
            {
                trouve = true;
            }
                else
                {
                    if (prenomRecherché != prenoms[milieu])
                    {

                    }
                }

            } while (trouve==true);



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
