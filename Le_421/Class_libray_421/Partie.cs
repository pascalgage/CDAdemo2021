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


        public Partie()
        {
            this.maMancheCourante = new Manche();
        }

        public void LancerLes3Des()
        {
            this.maMancheCourante.LancerLes3Des();
        }

        public void EstGagnee()
        {
            
        }

        public void AEncoreUneMancheAJouer()
        {
            
        }
    }
}