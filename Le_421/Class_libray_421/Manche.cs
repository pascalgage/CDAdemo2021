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

        public List<De> Mes3Des { get => mes3Des;}
        public int NbLancerCourant { get => nbLancerCourant; }

        public Manche()
        {
            this.mes3Des = new List<De> { new De(), new De(), new De() };
            this.nbLancerCourant = 1;
        }


        public void LancerLes3Des()
        {
            mes3Des[0].SeJeter();
            mes3Des[1].SeJeter();
            mes3Des[2].SeJeter();
            nbLancerCourant++;
        }

        public void Lancer(int numeroDe1, int numeroDe2)
        {
            mes3Des[numeroDe1].SeJeter();
            mes3Des[numeroDe2].SeJeter();
        }

        public void Lancer(int numeroDe)
        {
            mes3Des[numeroDe].SeJeter();
        }

        public bool AEncoreUnLance()
        {
            throw new System.NotImplementedException();
        }

        public bool AGagneLaManche()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "La valeur dé 1 est: " + mes3Des[0] + " La valeur dé 2 est: " + mes3Des[1] + " La valeur dé 3 est: " + mes3Des[2];
        }

        public string RenvoieUneRepresentationDesDes()
        {
            throw new System.NotImplementedException();
        }

        private void TrierLesDes()
        {
            throw new System.NotImplementedException();
        }
    }
}