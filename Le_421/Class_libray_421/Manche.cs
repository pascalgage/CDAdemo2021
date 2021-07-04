using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_libray_421
{
    public class Manche
    {
        private List<De> mes3Des;
        private const int NB_LANCER_MAX = 3;
        private int nbLancerCourant;

       
        
        public int NbLancerCourant { get => nbLancerCourant; }

        public Manche()
        {
            this.mes3Des = new List<De> { new De(), new De(), new De() };
            this.nbLancerCourant = 0;
        }


        public void LancerLes3Des()
        {
            mes3Des[0].SeJeter();
            mes3Des[1].SeJeter();
            mes3Des[2].SeJeter();
            nbLancerCourant++;
            TrierLesDes();
        }

        public void Lancer(int numeroDe1, int numeroDe2)
        {
            mes3Des[numeroDe1].SeJeter();
            mes3Des[numeroDe2].SeJeter();
            nbLancerCourant++;
            TrierLesDes();
        }

        public void Lancer(int numeroDe)
        {
            mes3Des[numeroDe].SeJeter();
            nbLancerCourant++;
            TrierLesDes();
        }
        public void Reinitialisation()
        {
            nbLancerCourant = 0;
        }
        public bool AEncoreUnLance()
        {
            bool encore=false;

            if (nbLancerCourant <= NB_LANCER_MAX)
            {
                encore = true;
            }
            else
            {
                encore = false;
            }
            return encore;
        }

        public bool AGagneLaManche()
        {
            
            bool gagneManche = false;
            
            if (mes3Des[0].Valeur==4 && mes3Des[1].Valeur==2 && mes3Des[2].Valeur == 1)
            {
                gagneManche = true;
                
            }
            else
            {
                gagneManche = false;
            }
            return gagneManche;
        }

        public override string ToString()
        {
            return "La valeur dé n°1 est: " + mes3Des[0] + " La valeur dé n°2 est: " + mes3Des[1] + " La valeur dé n°3 est: " + mes3Des[2];
        }

        public string RenvoieUneRepresentationDesDes()
        {
            string lesDes = "";

            for (int i = 0; i < mes3Des.Count; i++)
            {
                lesDes += " Le Dé n°"+(i+1)+"= "+  mes3Des[i];
            }

            return lesDes;
        }

        private void TrierLesDes()
        {
            mes3Des.Sort();
            mes3Des.Reverse();

        }
    }
}