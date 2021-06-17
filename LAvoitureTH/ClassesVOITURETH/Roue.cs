
using System;
using System.Collections.Generic;

namespace ClassesVOITURETH
{
	public class Roue {

		private int diametre;
		private bool tourne;

        public int Diametre { get => diametre; }
        public bool Tourne { get => tourne; }

        //constructeur par défaut
        public Roue()
		{
			diametre=15;
			tourne=false;

		}
		//constructeur classique
        public Roue(int diametre, bool tourne)
        {
            this.diametre = diametre;
            this.tourne = tourne;
        }
		//constructeur par clonage
		public Roue(Roue _roueACopier )
		{
			diametre = _roueACopier.diametre;
			tourne = _roueACopier.tourne;
		}
		

		public bool Tourner()
		{
			bool aReussiAMettreEnRotation = false;

            if (tourne == false)
            {
				aReussiAMettreEnRotation = true;
				tourne = true;
            }
            else
            {
				aReussiAMettreEnRotation = false;
            }
			return aReussiAMettreEnRotation;
		}
		public bool ArretTourner()
		{
			bool aReussiAMettreEnRotation = false;

			if (tourne == true)
			{
				aReussiAMettreEnRotation = true;
				tourne = false;
			}
			else
			{
				aReussiAMettreEnRotation = false;
			}
			return aReussiAMettreEnRotation;
		}


	}//end Roue

}//end namespace Voiture