using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Moteur
    {
        public bool moteurON = false;

        public Moteur()
        {
            this.moteurON = false;
        }

        public bool  Eteindre()
        {
            if (moteurON == true)
            {
                moteurON = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Allummer()
        {
            if (moteurON == false)
            {
                moteurON = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
