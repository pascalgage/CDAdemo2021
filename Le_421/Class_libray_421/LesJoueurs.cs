using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_libray_421
{
    [Serializable]

    public class LesJoueurs:List<Joueur> 
    {
        private List<Joueur> mesJoueurs;
   

        //Constructeur classique...

        public LesJoueurs(List<Joueur> _listeJoueurs)
        {
            this.mesJoueurs = _listeJoueurs;
    
        }

        //Constructeur par défaut...

        public LesJoueurs()
        {
            mesJoueurs = new List<Joueur>();
        }

        //Méthodes...
        public void AjouterUnJoueur(string _nom, int _score)
        {
            Joueur p = new Joueur(_nom, _score);
            this.mesJoueurs.Add(p);
        }


    }
}
