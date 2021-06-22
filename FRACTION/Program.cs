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
            Fraction d = new Fraction(11,7);
            Fraction e = new Fraction(5,4);

            Fraction f = new Fraction(128,64);
            Fraction g = new Fraction(6, 3);

            
            Console.WriteLine(f.GetPgcd());
            f.Reduire();

                Console.ReadKey();
        }
    }
}
