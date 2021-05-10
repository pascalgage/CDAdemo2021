using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3nbr_aet_bet_c
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Entrez un nombre a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un nombre b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un nombre c: ");
            c = double.Parse(Console.ReadLine());

      




            if (a < b && b<c)
            {
                Console.WriteLine("" + a + " " + b + " " + c);
            }
            else if (a < c && c < b)
            {
                Console.WriteLine("" + a + " " + c + " " + b);
            }
            else if (b < a && a < c)
            {
                Console.WriteLine("" + b + " " + a + " " + c);
            }


            else if (b < c && c < a)
            {
                Console.WriteLine("" + b + " " + c + " " + a);
            }
            else if (c < a && a < b)
            {
                Console.WriteLine("" + c + " " + a + " " + b);
            }
            else if (c < b && b < a)
            {
                Console.WriteLine("" + c + " " + b + " " + a);
            }





            Console.ReadKey();
        }
    }
}
