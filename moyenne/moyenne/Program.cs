using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moyenne
{
    public class Program
    {
        static void Main(string[] args)
        {
            //déclaration des variables
            double a;
            double b;
            double resultat;
            //Saisie des valeurs de a et b
            Console.WriteLine("Entrez un nombre a :");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un nombre b :");
            b = double.Parse(Console.ReadLine());
            //traitement

            resultat = MOY(a,b);

            //affichage du résultat
            Console.WriteLine("La moyenne de " + a + " et de " + b + " est de " + resultat);

            Console.ReadKey();
        }
        public static double MOY(double _a,double _b)
        {
            double resultat;

            resultat = (_a +_b) / 2;

            return resultat;
        }
    }
}
