using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_libray_421
{
    public class Partie
    {
        private Manche maMancheCourante;
        private int scoreCourant;
        private int nombreDeMancheJoue;
        private int nbMancheAJouer;


        public Partie(int _nbMancheAJouer)
        {
            this.maMancheCourante = new Manche();
            this.scoreCourant = 10*_nbMancheAJouer;
            this.nombreDeMancheJoue = 0;
            this.nbMancheAJouer = _nbMancheAJouer;
        }

        public void LancerLes3Des()
        {
            this.maMancheCourante.LancerLes3Des();
            
        }

        public void Lancer(int _numde,int _numde2)
        {
            this.maMancheCourante.Lancer(_numde,_numde2);
        }

        public void Lancer(int _numde)
        {
            this.maMancheCourante.Lancer(_numde);
        }

        public bool EstGagnee()
        {
            bool estGagne = false;
            if(scoreCourant>0 && nombreDeMancheJoue == nbMancheAJouer)
            {
                estGagne = true;
            }
            return estGagne;
        }
        

        public bool AEncoreUneMancheAJouer()
        {
            bool encoreManche=false;
            if (nbMancheAJouer > 0)
            {
                encoreManche = true;
            }
            return encoreManche;
        }
    }
}