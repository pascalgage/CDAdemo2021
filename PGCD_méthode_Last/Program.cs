using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD_méthode_Last
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int div;

            Console.WriteLine("Veuillez entrer un nombre entier positif A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un nombre entier positif B:");
            b = int.Parse(Console.ReadLine());

            Console.Write(PGCD.Get_Pgcd(a, b));

            Console.ReadKey();

        }
    }
}
