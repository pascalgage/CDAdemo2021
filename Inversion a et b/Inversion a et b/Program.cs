using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_a_et_b
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            double temp;

            //saisie des entrées
            Console.WriteLine("Entrez une valeur pour a :");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez une valeur pour b :");
            b = double.Parse(Console.ReadLine());

            //traitement
            temp = a;
            a=b;
            b = temp;

            //Affichage du résultat
            Console.WriteLine("a est égal à:" + a);
            Console.WriteLine("b est égal à:" + b);




            Console.ReadKey();
        }
        public static void INVERSION(ref double a, ref double b)
        {

        }
    }
}
