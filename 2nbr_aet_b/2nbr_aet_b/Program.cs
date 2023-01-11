using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nbr_aet_b
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            

            Console.WriteLine("Entrez un nombre a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un nombre b:");
            b = double.Parse(Console.ReadLine());

            INVERSION(ref a,ref b);

            Console.WriteLine("a devient:"+a);
            Console.WriteLine("b devient:"+b);

            Console.ReadKey();

        }
        public static void INVERSION(ref double _a, ref double _b)
        {
            double temp=_a;
            _a = _b;
            _b = temp;

        }
    }
}
