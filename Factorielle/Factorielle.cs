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
    }
}
