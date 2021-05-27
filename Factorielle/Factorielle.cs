using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorielle
{
    class Factorielle
    {
        public static double Factor(double _nbr)
        {
            double resultat = _nbr;
            double _exp = _nbr;

            while (_exp != 1)
            {
                _exp--;
                resultat = resultat * _exp;

            }
            return resultat;
        }

        public static uint RecursivF(uint _nbr)
        {

            uint resultat =0;

            if (_nbr == 1)
            {
                resultat = 1;
            }
            else
            {
                resultat = _nbr * RecursivF(_nbr - 1);
            }

            return resultat;
            
        }
        public static double Exposant(double _nbr, double _exp)
        {
            double resultat = 0;

            if (_exp == 0) { resultat = 1; }
            
            else
            {
                resultat = _nbr * Exposant(_nbr, _exp - 1);
            }
            return resultat;
        }
    }
}
