using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Entrez un nombre a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un nombre b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un nombre c:");
            c = double.Parse(Console.ReadLine());
        }
    }
}
