using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEUNES
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jeunes = new int[20];

            for (int i = 0; i < jeunes.Length; i++)
            {
                Console.WriteLine("Entrez l'âge de la personne n°" + (i + 1));
                jeunes[i] = int.Parse(Console.ReadLine());
            }
            int moinsdevingt = 0;

            foreach(int age in jeunes)
            {
                if (age < 20)
                {
                    moinsdevingt++;
                }
            }

            Console.WriteLine("Les personnes ayant moins de vingt ans sont au nombre de : "+ moinsdevingt);

            Console.ReadKey();
        }
    }
}
