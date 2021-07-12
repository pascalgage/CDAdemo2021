using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_libray_421
{
    [Serializable]
    public class Joueur
    {
        private string nom;
        private int score;

        public string Nom { get => nom; }
        public int Score { get => score; }

        //Constructeur classique...
        public Joueur(string _nom, int _score)
        {
            this.nom = _nom;
            this.score = _score;
        }
        //Constructeur par défaut...
        public Joueur()
        {
            nom = "Julien";
            score = 100;
        }

        public override string ToString()
        {
            return "NOM:" + this.Nom + "SCORE:" + Score;
        }
    }
}
