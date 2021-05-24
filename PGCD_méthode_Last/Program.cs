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
            int c;

            Console.WriteLine("Veuillez entrer un nombre entier positif A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un nombre entier positif B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un nombre entier positif C:");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Le PGCD de " + a + " et " + b + " et " + c + " est :");
            Console.Write(PGCD.Get_Pgcd(a, b, c));

            Console.ReadKey();

        }
    }
}
