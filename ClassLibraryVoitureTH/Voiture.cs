///////////////////////////////////////////////////////////
//  Voiture.cs
//  Implementation of the Class Voiture
//  Generated by Enterprise Architect
//  Created on:      14-juin-2021 16:28:15
//  Original author: sophi
///////////////////////////////////////////////////////////




using System.Collections.Generic;

namespace ClassLibraryVoitureTH
{
	public class Voiture
	{

		private int compteurEnKM;
		
		private Moteur sonMoteur;

		private List<Roue> mesRoues;


        //constructeur par d�faut
        public Voiture()
        {
            compteurEnKM = 0;
			mesRoues = new List<Roue>();
			sonMoteur = new Moteur();

        }
       
		//constructeur classique
		private Voiture(int compteurEnKM, Moteur sonMoteur, List<Roue> mesRoues)
        {
			this.compteurEnKM = compteurEnKM;
			this.sonMoteur = sonMoteur;
			this.mesRoues = mesRoues;
        }

		public Voiture(int compteurEnKM, bool estDemarre, int nbCV, List<Roue> mesRoues)
		{
			this.compteurEnKM = compteurEnKM;
			this.sonMoteur = new Moteur(estDemarre,nbCV);
            
            
		}
		//constructeur par recopie
		public Voiture(Voiture _voitACopier)
        {
			//pour le compteur
			this.compteurEnKM = _voitACopier.compteurEnKM;
			//pour les roues
			this.mesRoues = new List<Roue>();
			this.mesRoues.Add(new Roue(_voitACopier.mesRoues[0]));
			this.mesRoues.Add(new Roue(_voitACopier.mesRoues[1]));
			this.mesRoues.Add(new Roue(_voitACopier.mesRoues[2]));
			this.mesRoues.Add(new Roue(_voitACopier.mesRoues[3]));

			//pour le moteur
			this.sonMoteur = new Moteur( _voitACopier.sonMoteur);
			
        }
		

		public bool Arreter(){

			return true;
		}

		public bool Avancer(){

			return false;
		}

		public bool Demarrer(){

			return false;
		}

	}//end Voiture

}//end namespace Voiture