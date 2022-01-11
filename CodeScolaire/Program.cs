using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeScolaire
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int nombre = 0;
            Console.WriteLine("Veuillez saisir un nombre pour obtenir les 10 suivants");
            nombre = int.Parse(Console.ReadLine());

            List<int> cible = new List<int>();

            for(int i=nombre+1; i<=(nombre+10); i++)
            {
                cible.Add(i);
            }
            Console.Clear();
            for(int i=0; i<cible.Count; i++)
            {
                Console.WriteLine(cible[i]);
            }*/

            /*int table = 0;
            Console.WriteLine("Veuillez saisir le chiffre dont vous souhaitez obtenir la table de multiplication :");
            table = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(table * i);
            }*/

            int nbr = 0;
            int result = 0;
            Console.WriteLine("Donnez votre nombre de départ: ");
            nbr = int.Parse(Console.ReadLine());

            for(int i=1; i <= nbr; i++)
            {
                result +=i;
            }
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
