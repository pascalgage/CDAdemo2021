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
            Fraction d = new Fraction(12,4);
            Fraction e = new Fraction(-6,2);

            Fraction f = new Fraction(-128,64);
            Fraction g = new Fraction(-6,-3);

            Fraction res=d.Moins(e);
            Console.WriteLine(res.ToString());

            Console.ReadKey();
        }
    }
}
