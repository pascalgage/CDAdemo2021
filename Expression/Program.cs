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
            

            ClassLibraryExpression.Expression exp2 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
            

            ClassLibraryExpression.Expression exp3 = new Soustraction(new Nombre(12), new Nombre(6));

            ClassLibraryExpression.Expression exp4 = new Soustraction(new Nombre(6), new Soustraction(new Nombre(12), new Nombre(9)));
            ClassLibraryExpression.Expression exp5 = new Soustraction(new Soustraction(new Nombre(6), new Nombre(12)), new Nombre(9));

            string resultat3 = exp4.Sformate();
            string resultat4 = exp5.Sformate();

            

            
            Console.WriteLine(resultat3);
            Console.WriteLine(resultat4);
            

            Console.ReadKey();
        }
    }
}
