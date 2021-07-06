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

        public int ScoreCourant { get => scoreCourant; }
        public int NombreDeMancheJoue { get => nombreDeMancheJoue; }
        public int NbMancheAJouer { get => nbMancheAJouer; }

        public Partie(int _nbMancheAJouer)
        {
            this.maMancheCourante = new Manche();
            this.scoreCourant = 10*_nbMancheAJouer;
            this.nombreDeMancheJoue = 0;
            this.nbMancheAJouer = _nbMancheAJouer;
        }

        public void MancheOK()
        {
            if (this.maMancheCourante.AGagneLaManche() == true)
            {
                this.scoreCourant += 30;
                
                
            }
        }
        public void MancheJoueePerdue()
        {
            if (this.maMancheCourante.AGagneLaManche() == false)
            {
                this.scoreCourant -= 10;
                nombreDeMancheJoue++;

            }

        }
        public void Reinitialisation()
        {
            this.maMancheCourante.Reinitialisation();
        }

        public void LancerLes3Des()
        {
            this.maMancheCourante.LancerLes3Des();
            
        }

        public void Lancer(int _numde, int _numde2,int _numde3)
        {
            this.maMancheCourante.Lancer(_numde, _numde2, _numde3);
        }


        public void Lancer(int _numde,int _numde2)
        {
            this.maMancheCourante.Lancer(_numde,_numde2);
        }

        public void Lancer(int _numde)
        {
            this.maMancheCourante.Lancer(_numde);
        }

        public bool PartieEstGagnee()
        {
            return scoreCourant > 0 && nbMancheAJouer == 0;
        }
        

        public bool AEncoreUneMancheAJouer()
        {
            return nbMancheAJouer > 0 && scoreCourant > 0;
        }

        public string RenvoieUneRepresentationDesDes()
        {
            return this.maMancheCourante.RenvoieUneRepresentationDesDes();
        }

        public bool AGagneLaManche()
        {
            return this.maMancheCourante.AGagneLaManche();
           
        }

        public bool AEncoreUnLance()
        {
            return this.maMancheCourante.AEncoreUnLance();
        }

        public List<int> SaisieDesNumdeDe(string textesaisi)
        {
            List<int>value = new List<int>();
            string[] valeurs = textesaisi.Split(new char[]{ ' ',',','/'}) ;
            
            
            foreach(string item in valeurs)
            {
                int valeurconvertit= Convert.ToInt32(item);
                value.Add(valeurconvertit);
            }

            return value;
            
        }
    }
}