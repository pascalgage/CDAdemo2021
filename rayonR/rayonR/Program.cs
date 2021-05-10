using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rayonR
{
    public class Program
    {
        static void Main(string[] args)
        {
            //déclaration des variables
            double r;
            double resultat_aire;
            double resultat_volume;

            //saisie des entrées
            Console.WriteLine("Entrez le rayon d'une sphère :");
            r = double.Parse(Console.ReadLine());

            //traitement...
            resultat_aire = Aire(r); //appel de la méthode Aire
            Console.WriteLine("L'aire de la sphère est de :" + Math.Round(resultat_aire,2));

            resultat_volume = Volume(r); //appel de la méthode Volume
            Console.WriteLine("Le volume de la sphère est de :" + Math.Round(resultat_volume,2));

            Console.ReadKey();
        }
        public static double Aire(double _r)
        {
            double aire;

            aire = 4 * (Math.PI) * Math.Pow(_r, 2);

            return aire;
        }

        public static double Volume(double _r)
        {
            double volume;

            volume= ((double)4)/3* (Math.PI)* Math.Pow(_r, 3);

            return volume;
        }

    }
}
