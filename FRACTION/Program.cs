using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FRACTION_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction d = new Fraction(12,7);
            Fraction e = new Fraction(5400,-1350);

            Fraction f = new Fraction(128,64);
            Fraction g = new Fraction(6, 3);

            Console.WriteLine(d.GetPgcd());
            Console.WriteLine(d);
            Console.WriteLine(d.ToString());

            e.Reduire();
            Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
