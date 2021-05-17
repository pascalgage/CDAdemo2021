using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECH_TAB_nbr
{
    class Class1
    {
        public static void Tri_Bull(int[] _Tab)
        {
            int temp = 0;
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
    }
}
