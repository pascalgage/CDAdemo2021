using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiviseur
{
    public class Diviseur1
    {
        public static List<uint> Diviseur(uint _nbr)
        {
            uint diviseur = 2;
            List<uint> Listing = new List<uint>();

            do
            {
                if (_nbr % diviseur == 0)
                {
                    Listing.Add(diviseur);
                }
                diviseur++;

            } while (diviseur < _nbr);

            return Listing;
        }
        public static bool EstUnNombrepremier(uint _nbATester)

        {
            double reste;
            int diviseur = 2;
            bool estPremier = true;

            //_nbATester == 0 , il a une infinite de diviseur
            //_nbATester == 1 , il a qu'un diviseur, lui même

            if ((_nbATester == 0) || (_nbATester == 1))
            {
                estPremier = false;
            }
            else
            {
                while ((diviseur < _nbATester) && estPremier)
                {
                    reste = _nbATester % diviseur;

                    diviseur++;

                    if (reste == 0)
                    {
                        estPremier = false;

                    }

                }
            }
            return estPremier;
        }
    }
}
