using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRACTION_CLASS;

namespace FRACTION_CLASS
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int d;
            int e;

            Console.WriteLine("Entrez le numérateur de la fraction 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le dénominateur de la fraction 1");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le numérateur de la fraction 2");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le dénominateur de la fraction 2");
            e = int.Parse(Console.ReadLine());

            Console.Clear();

            Fraction c = new Fraction(a, b);
            Fraction f = new Fraction(d, e);

            Console.WriteLine("L'addition de " + a + "/" + b + " et de "+d+"/"+e+" est égale à :");
            Fraction resPlus = c.Plus(f);
            resPlus.GestionSigne();
            Console.WriteLine(resPlus.ToString());

            Console.WriteLine("");

            Console.WriteLine("La soustraction de " + a + "/" + b + " et de " + d + "/" + e + " est égale à :");
            Fraction resMoins = c.Moins(f);
            resMoins.GestionSigne();
            Console.WriteLine(resMoins.ToString());

            Console.WriteLine("");

            Console.WriteLine("La multiplication de " + a + "/" + b + " et de " + d + "/" + e + " est égale à :");
            Fraction resMulti = c.Multiplie(f);
            resMulti.GestionSigne();
            Console.WriteLine(resMulti.ToString());

            Console.WriteLine("");

            Console.WriteLine("La division de " + a + "/" + b + " et de " + d + "/" + e + " est égale à :");
            Fraction resDivis = c.Divise(f);
            resDivis.GestionSigne();
            Console.WriteLine(resDivis.ToString());

            Console.WriteLine("");

            Console.WriteLine("REDUCTION de : "+a + " / " + b);
            c.Reduire();
            c.GestionSigne();
            Console.WriteLine(c.ToString());

            Console.WriteLine("REDUCTION de : " + d + " / " + e);
            f.Reduire();
            f.GestionSigne();
            Console.WriteLine(f.ToString());

            Console.WriteLine("");

            Console.WriteLine("VALEUR NUMERIQUE de : " + a + " / " + b);
            Console.WriteLine(c.Evalue(a,b));

            Console.WriteLine("VALEUR NUMERIQUE de : " + d + " / " + e);
            Console.WriteLine(f.Evalue(d,e));
            
            

            Console.ReadKey();
        }
    }
}
