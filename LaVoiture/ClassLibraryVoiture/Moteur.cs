using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Moteur
    {
        //Attributs...
        private bool moteurON = false;

        //Propriétés...
        public bool MoteurON
        {
            get { return moteurON; }
            

        }

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
