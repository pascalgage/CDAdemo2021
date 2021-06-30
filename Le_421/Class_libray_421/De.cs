using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_libray_421
{
    public class De : IComparable<De>, IComparable
    {
        private const int NB_FACE = 6;
        private int valeur;

        public De()
        {
            valeur = Alea.Instance().Nouveau(1, NB_FACE);
        }

        public int Valeur
        {
            get => valeur;

        }

        public int CompareTo(De other)
        {
          return  this.valeur.CompareTo(other.valeur);
        }

        public int CompareTo(object obj)
        {
            throw new System.NotImplementedException();
        }

        public void SeJeter()
        {
            this.valeur = Alea.Instance().Nouveau(1, NB_FACE);
        }

        public override string ToString()
        {
            return "La valeur est: "+valeur;
        }
    }
}
