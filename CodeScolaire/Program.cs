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
            int nombre = 0;
            Console.WriteLine("Veuillez saisir un nombre pour obtenir les 10 suivants");
            nombre = int.Parse(Console.ReadLine());

            List<int> cible = new List<int>();

            for(int i=nombre; i<=(nombre+10); i++)
            {
                cible.Add(i);
            }

            for(int i=0; i<cible.Count; i++)
            {
                Console.WriteLine(cible[i]);
            }

            Console.ReadKey();
        }
    }
}
