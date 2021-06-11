using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Moteur
    {
        private bool moteurTourne = false;

        public Moteur()
        {

        }

        public bool  Eteindre()
        {
            if (moteurTourne == true)
            {
                moteurTourne = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Allummer()
        {
            if (moteurTourne == false)
            {
                moteurTourne = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
