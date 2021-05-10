using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bissextile
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;

            Console.WriteLine("Entrez une année :");
            A = int.Parse(Console.ReadLine());

            if (A % 4 != 0)
            {
                Console.WriteLine("Non Bissextile");
            }

            else
            {

                if (A % 100 != 0)
                {
                    Console.WriteLine("Bissextile");
                }
                else
                {
                    if (A % 400 != 0)
                    {
                        Console.WriteLine("non Bissextile");
                    }
                    else
                    {
                        Console.WriteLine("Bissextile");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
