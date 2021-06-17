




using System.Collections.Generic;

namespace ClassesVOITURETH
{
	public class Voiture
	{

		private int compteurEnKM;
		
		private Moteur sonMoteur;

		private List<Roue> mesRoues;

        public Moteur SonMoteur { get => sonMoteur;  }
        public int CompteurEnKM { get => compteurEnKM; }
        public List<Roue> MesRoues { get => mesRoues;}


        //constructeur par défaut
        public Voiture()
        {
            compteurEnKM = 0;
			mesRoues = new List<Roue>();
			mesRoues.Add(new Roue());
			mesRoues.Add(new Roue());
			mesRoues.Add(new Roue());
			mesRoues.Add(new Roue());
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
			this.mesRoues = mesRoues;
            
		}
		//constructeur par recopie
		public Voiture(Voiture _voitACopier)
		{
			//pour le compteur
			this.compteurEnKM = _voitACopier.compteurEnKM;
			//pour les roues
			this.mesRoues = new List<Roue>();
			this.mesRoues[0] = new Roue();
			this.mesRoues[1] = new Roue();
			this.mesRoues[2] = new Roue();
			this.mesRoues[3] = new Roue();
		}

		private Voiture(int compteurEnKm, bool tourne, int diametre, bool estDemarre, int nbCV)
            {
                //pour le compteur

                this.compteurEnKM = compteurEnKm;

                //pour les roues

                this.mesRoues = new List<Roue>();
                this.mesRoues[0] = new Roue(diametre,tourne);
                this.mesRoues[1] = new Roue(diametre,tourne);
                this.mesRoues[2] = new Roue(diametre,tourne);
                this.mesRoues[3] = new Roue(diametre,tourne);

                //pour le moteur

                this.sonMoteur = new Moteur(estDemarre, nbCV);
            }



			//this.mesRoues.Add(new Roue(_voitACopier.mesRoues[0]));
			//this.mesRoues.Add(new Roue(_voitACopier.mesRoues[1]));
			//this.mesRoues.Add(new Roue(_voitACopier.mesRoues[2]));
			//this.mesRoues.Add(new Roue(_voitACopier.mesRoues[3]));

			//pour le moteur
			//this.sonMoteur = new Moteur( _voitACopier.sonMoteur);
			
        
		

		public void Arreter()
		{

			this.sonMoteur.ArreterEntrainer(mesRoues[0], mesRoues[1]);
		}

		public bool Avancer()
		{
			bool aReussiAvancer = this.sonMoteur.Entrainer(mesRoues[0], mesRoues[1]);
			/*if (sonMoteur.Demarrer() == true && mesRoues[0].Tourner() == true && mesRoues[1].Tourner()==true)
            {
				mesRoues[0].Tourner();
				mesRoues[1].Tourner();
				aReussiAvancer = true;
            }
            else
            {
				aReussiAvancer = false;
            }*/
			return aReussiAvancer;
			
		}

		public bool Demarrer()
		{
			bool aREussiADemarrer = false;
            if (sonMoteur.Demarrer() == true)
            {
				sonMoteur.Demarrer();
				aREussiADemarrer = true;
            }
            else
            {
				aREussiADemarrer = false;
            }
			return aREussiADemarrer;
			
		}

	}//end Voiture

}//end namespace Voiture