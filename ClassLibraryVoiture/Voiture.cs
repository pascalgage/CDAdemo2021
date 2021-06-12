using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Voiture  :Moteur
    {
        //attributs
        private string modele;
        private Moteur moteurTourne;
        private Roue roueTourne;

        bool demarre = false;

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
            
            

        }

        public bool Demarrer()
        {
            
            if (moteurON == true)
            {
                Console.WriteLine("Vroum Vroum");
                demarre=true;
            }
            else
            {
                Console.WriteLine("Rien");
                demarre=false;
            }
            return demarre;
        }

        public void Arreter()
        {
            
        }

        public void Avancer()
        {
            if(moteurON==true && demarre==true)
            {
                Console.WriteLine("Je file à 100 km/h !!!");
            }
            else
            {
                Console.WriteLine("0 km/h");
            }
        }
    }
}
