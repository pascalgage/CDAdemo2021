using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECH_TAB_nbr
{
    class Class1
    {
        public static void Tri_Bull(uint[] _Tab)
        {
            uint temp = 0;
            bool tri = false;

            while (tri == false)
            {
                tri = true;
                for (int i = 0; i < _Tab.Length - 1; i++)
                {
                    if (_Tab[i] > _Tab[i + 1])
                    {
                        tri = false;
                        temp = _Tab[i];
                        _Tab[i] = _Tab[i + 1];
                        _Tab[i + 1] = temp;
                    }

                }
            }
        }

        public static string Search_aNUM(uint[] _monTab, uint _monNBR)
        {
            string resultat=" ";
            
            bool test = false;

            

            for (int i = 0; i < _monTab.Length; i++)
            {

                if (_monTab[i] == _monNBR)
                {
                    test = true;
                    resultat=(_monNBR + " se trouve à la position " + (i + 1));

                }

            }
            if (test == false)
            {
                resultat=(_monNBR + " n'existe pas dans le tableau");
            }

            return resultat;
        }
    }
}
