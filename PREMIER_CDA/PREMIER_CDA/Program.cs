using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREMIER_CDA
{
    class Program
    {
        static void Main(string[] args)
        {
            double NBR;
            bool test = true;

            Console.WriteLine("Entrez un nombre entier non-nul et positif:");
            NBR = double.Parse(Console.ReadLine());

            test=nombrepremier(NBR);
            if (test == true && NBR!=1) { Console.WriteLine(NBR+ " est Premier"); }
            else { Console.WriteLine(NBR+ " n'est pas Premier"); }


            Console.ReadKey();
        }
        public static bool nombrepremier(double _Nbutilisateur)

        {
            double reste;
            int Diviseur = 2;
            bool Premier = true;
            double Limite = Math.Sqrt(_Nbutilisateur);

            do
            {
                reste = _Nbutilisateur % Diviseur;
                Diviseur++;
                if (reste == 0 && _Nbutilisateur != 2)
                {
                    Premier = false;
                    break;
                }

            } while (Diviseur <= Limite);

            return Premier;
        }
    }
}
