using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPREMIER
{
    public class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_nbATester"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbMaximunATester"></param>
        /// <returns></returns>
        public static List<uint> DonneLesPremiers(uint nbMaximunATester)
        {
            List<uint> tab = new List<uint>();

            for (uint i = 0; i <= nbMaximunATester; i++)
            {
                
                if (EstUnNombrepremier(i) == true )
                {
                    tab.Add(i);
                }
            }
            return tab;
        }
    }
}
