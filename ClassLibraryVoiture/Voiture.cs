using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Voiture
    {
        //attributs
        private string modele;
        private Moteur moteurTourne;
        private Roue roueTourne;

        //propriétés
        public string Modele { get => modele; }
        public Moteur MoteurTourne { get => moteurTourne; }
        public Roue RoueTourne { get => roueTourne; }

        //contructeur classique
        public Voiture(string _modele, Moteur _moteurTourne, Roue _roueTourne)
        {
            this.modele = _modele;
            this.moteurTourne = _moteurTourne;
            this.roueTourne = _roueTourne;
        }
        //constructeur par défaut
        public Voiture(string _modele)
        {

            this.modele = _modele;
            this.moteurTourne = new Moteur();
            this.roueTourne = new Roue();

        }

        public void Demarrer()
        {
            
        }

        public void Arreter()
        {
            
        }

        public void Avancer()
        {
            
        }
    }
}
