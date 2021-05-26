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
            double f=0;

            Console.WriteLine("Entrez un nombre F:");
            f=double.Parse(Console.ReadLine());

            Console.WriteLine(Factorielle.Factor(f));
            Console.WriteLine(Factorielle.RecursivF(f));
            Console.ReadKey();
        }
    }
}
