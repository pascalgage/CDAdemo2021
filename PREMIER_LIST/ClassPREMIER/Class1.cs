using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPREMIER
{
    public class Class1
    {
        public static bool Nombrepremier(int _Nbutilisateur)

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
        public static List<int> GivePremier(int Nbr)
        {
            List<int> tab = new List<int>();

            for (int i = 0; i < Nbr; i++)
            {
                
                if (Nombrepremier(i) == true && i != 1)
                {
                    tab.Add(i);
                }
            }
            return tab;
        }
    }
}
