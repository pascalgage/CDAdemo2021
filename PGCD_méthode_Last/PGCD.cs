using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD_méthode_Last
{
    public class PGCD
    {
        public static int Get_Pgcd(int _a, int _b)
        {
            int div = 1;
            List<int> Tab = new List<int>();

            while(div<_a && div < _b)
            {
                div++;

                if(_a%div==0 && _b % div == 0)
                {
                    Tab.Add(div);
                }
            }
            return Tab.Last();
        }
    }
}
