


namespace ClassesVOITURETH
{
	public class Moteur 
	{

		private bool estDemarre;
		private int nbCV;

        public bool EstDemarre { get => estDemarre; }
        public int NbCV { get => nbCV; }

        //constructeur par défaut
        public Moteur()
		{
			estDemarre = false;
			nbCV = 4;
		}
	
		//constructeur classique
		public Moteur(bool estDemarre, int nbCV)
		{
			this.estDemarre = estDemarre;
			this.nbCV = nbCV;
		}
        //constructeur par clonage
        public Moteur(Moteur _cloneMoteur)
        {
            estDemarre = _cloneMoteur.estDemarre;
            nbCV = _cloneMoteur.nbCV;
        }
	

        public bool Demarrer()
		{
			bool aReussiADEMarrer = false;

            if (estDemarre == false)
            {
				estDemarre = true;
				aReussiADEMarrer = true;
            }
            else
            {
				aReussiADEMarrer = false;
            }

			return aReussiADEMarrer;
		}

		
		public bool Entrainer(Roue roueMotrice2, Roue roueMotrice1)
		{
			bool ok=false ;
			if(estDemarre==true)
            {
				bool okRoueMotrice1 =roueMotrice1.Tourner();
				bool okRoueMotrice2 = roueMotrice2.Tourner();
				ok = okRoueMotrice1 && okRoueMotrice2;
			}
			return ok;
		}
		public bool ArreterEntrainer(Roue roueMotrice2, Roue roueMotrice1)
		{
			bool ok = false;
			if (estDemarre == true)
			{
				bool okRoueMotrice1 = roueMotrice1.ArretTourner();
				bool okRoueMotrice2 = roueMotrice2.ArretTourner();
				ok = okRoueMotrice1 && okRoueMotrice2;
			}
			return ok;
		}

	}//end Moteur

}//end namespace Voiture