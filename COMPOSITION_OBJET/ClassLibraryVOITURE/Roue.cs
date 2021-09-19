using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITION_OBJET
{
    public class Roue
    {
        //Attributs....
        private int diametre;
        private bool tourne;
        //Propriétés...
        public int Diametre { get => diametre; }
        public bool Tourne { get => tourne; }

        //Constructeur par défaut...
        public Roue()
        {
            this.diametre = 12;
            this.tourne = false;
        }
        //Constructeur Classique...
        public Roue(int _diametre, bool _tourne)
        {
            this.diametre = _diametre;
            this.tourne = _tourne;
        }
        //Constructeur par recopie...
        public Roue(Roue _aRecopie)
        {
            this.diametre = _aRecopie.diametre;
            this.tourne = _aRecopie.tourne;
        }


    }
}
