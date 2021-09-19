using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITION_OBJET
{
    public class Moteur
    {
        //Attributs...
        private int cylindre;
        private bool moteurTourne;
        //Propriétés...
        public int Cylindre { get => cylindre; }
        public bool MoteurTourne { get => moteurTourne; }

        //Constructeur par défaut...
        public Moteur()
        {
            cylindre = 1600;
            moteurTourne = false;
        }
        //Constructeur classique...
        public Moteur(int _cylindre,bool _moteurTourne)
        {
            this.cylindre = _cylindre;
            this.moteurTourne = _moteurTourne;
        }
        //Constructeur par clonage...
        public Moteur(Moteur _motArecopie)
        {
            this.cylindre = _motArecopie.cylindre;
            this.moteurTourne = _motArecopie.moteurTourne;
        }
    }
}
