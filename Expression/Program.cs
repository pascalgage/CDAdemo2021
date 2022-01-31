using ClassLibraryExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ClassLibraryExpression.Expression exp1 = new Addition(new Nombre(33), new Nombre(33));
            int resultat1 = exp1.Evalue();

            ClassLibraryExpression.Expression exp2 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
            int resultat2 = exp2.Evalue();

            ClassLibraryExpression.Expression exp3 = new Soustraction(new Nombre(12), new Nombre(6));
            int resultat3 = exp3.Evalue();
            string resultat4 = exp1.Formate();
            string resultat5 = exp2.Formate();

            Console.WriteLine(resultat1);
            Console.WriteLine(resultat2);
            Console.WriteLine(resultat3);
            Console.WriteLine(resultat4);
            Console.WriteLine(resultat5);

            Console.ReadKey();
        }
    }
}
