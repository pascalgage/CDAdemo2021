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

            Fraction f = new Fraction(24,12);
            Fraction g = new Fraction(6, 3);

            if (d.SuperieurA(e) == true)
            {
                Console.WriteLine("La fraction " + d + " est supérieur à " + e);
            }
            else
            {
                Console.WriteLine("N'est pas supérieur !");
            }

            if (d.EgalA(e) == true)
            {
                Console.WriteLine("La fraction " + d + " est égale à " + e);
            }
            else   
            {
                Console.WriteLine("N'est pas égal !");
            }
            if (d.EstInferieurA(e) == true)
            {
                Console.WriteLine("La fraction " +g + " est inférieure à " + f);
            }
            else
            {
                Console.WriteLine("N'est pas supérieure !!!");
            }

            Console.WriteLine(f.GetPgcd());

                Console.ReadKey();
        }
    }
}
