using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiviseur
{
    public class Diviseur1
    {
        public static List<int> Diviseur(int _nbr)
        {
            int diviseur = 2;
            List<int> Listing = new List<int>();

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
    }
}
