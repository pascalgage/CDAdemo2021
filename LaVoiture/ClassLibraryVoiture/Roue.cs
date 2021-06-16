using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Roue:Moteur
    {
        private bool roueTourne = false;

       public bool RoueTourne
        {
            get { return roueTourne; }
        }


        public Roue()
        {
            this.roueTourne = false;
        }

        public bool FaireTournerRoue()
        {
            if(MoteurON==true)
            {
                roueTourne = true;
            }
            return roueTourne;
        }

        public bool ArreterRoue()
        {
            if (MoteurON == false)
            {
                roueTourne = false;
            }
            return roueTourne;
            
        }
    }
}

