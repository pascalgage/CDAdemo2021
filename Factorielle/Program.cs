using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorielle
{
    class Program
    {
        static void Main(string[] args)
        {
            uint f=0;
            double p = 0;
            double y = 0;

            Console.WriteLine("Entrez un nombre F:");
            f=uint.Parse(Console.ReadLine());

            Console.WriteLine(Factorielle.Factor(f));
            Console.WriteLine(Factorielle.RecursivF(f));

            Console.WriteLine("Entrez un nombre P:");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine("à l'exposant Y:");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine(Factorielle.Exposant(p, y));

            Console.ReadKey();
        }
    }
}
