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
            Fraction d = new Fraction(1,-2);
            Fraction e = new Fraction(5,4);

            Fraction f = new Fraction(128,64);
            Fraction g = new Fraction(6, 3);

            Console.WriteLine(d.GetPgcd());
            Console.WriteLine(f.GetPgcd());
            f.Reduire();
            Console.WriteLine(f);
            d.Reduire();
            Console.WriteLine(d);
            Console.WriteLine(d.ToString());

            Console.ReadKey();
        }
    }
}
