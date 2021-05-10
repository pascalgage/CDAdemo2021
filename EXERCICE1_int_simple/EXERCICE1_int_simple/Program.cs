using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE1_int_simple
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            double capital;
            double tx;
            uint duree;

            double interet;//calcul des intêrets
            double resultat;//calcul de la somme placéé plus les intêrets

            //Saisie des entrées
            Console.WriteLine ("Entrez le capital à placer :");
            capital= double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le taux d'intêret annuel en %:");
            tx = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez la durée d'épargne en nombre d'années:");
            duree = uint.Parse(Console.ReadLine());

            //Traitement...

            interet = InteretsSIMPLES(capital,tx,duree); //appel de la méthode Intêrets
            Console.WriteLine("Les intêrets sont de :"+interet);

            resultat = InteretsComposes(capital,tx,duree);
            Console.WriteLine("Le capital valorisé au bout de "+duree+" an(s) est de :" + resultat);


            Console.ReadKey();

        }
        public static double InteretsSIMPLES(double _capital, double _tx, double _duree)
        {
            double resultat;

            resultat = _capital+((_capital * (_tx) / 100)*_duree);

            return resultat;
        }

        public static double InteretsComposes(double _capital, double _tx, uint _duree)
        {
            double resultat;

            resultat= (_capital *  Math.Pow(1+(_tx/100), _duree));

            return resultat;
        }
        
    }
}
