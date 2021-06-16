///////////////////////////////////////////////////////////
//  Moteur.cs
//  Implementation of the Class Moteur
//  Generated by Enterprise Architect
//  Created on:      14-juin-2021 16:28:21
//  Original author: sophi
///////////////////////////////////////////////////////////



namespace ClassLibraryVoitureTH
{
	public class Moteur {

		private bool estDemarre;
		private int nbCV;

		//constructeur par d�faut
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

        //public Moteur(Moteur _cloneMoteur2)

        //{
        //	 :this(_cloneMoteur2.estDemarre, _cloneMoteur2.nbCV);
        //}





        public bool Demarrer(){

			return false;
		}

		/// 
		/// <param name="roueMotrice2"></param>
		/// <param name="roueMotrice1"></param>
		public void Entrainer(Roue roueMotrice2, Roue roueMotrice1){

		}

	}//end Moteur

}//end namespace Voiture