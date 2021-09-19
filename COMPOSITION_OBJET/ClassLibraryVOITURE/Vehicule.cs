using COMPOSITION_OBJET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVOITURE
{
    public class Vehicule
    {
        //Attributs...
        private string marque;
        private Moteur sonMoteur;
        private List<Roue> sesRoues;
        private string v;

        //Propriétés...
        public string Marque { get => marque; }
        public Moteur SonMoteur { get => sonMoteur; }
        public List<Roue> SesRoues { get => sesRoues; }
        //Constructeur par défaut...
        public Vehicule()
        {
            marque = "Ferrari";
            sonMoteur = new Moteur();
            sesRoues = new List<Roue> ();
            sesRoues.Add(new Roue());
            sesRoues.Add(new Roue());
            sesRoues.Add(new Roue());
            sesRoues.Add(new Roue());
        }
        //Constructeur Classique...
        public Vehicule(string marque, Moteur sonMoteur, List<Roue> sesRoues)
        {
            this.marque = marque;
            this.sonMoteur= sonMoteur;
            this.sesRoues = sesRoues;
        }
        //Constructeur par clonage....
        public Vehicule(Vehicule _vehiculeArecopie)
        {
            this.marque = _vehiculeArecopie.marque;
            this.sonMoteur = _vehiculeArecopie.sonMoteur;
            this.sesRoues = new List<Roue>();
            this.sesRoues[0] = new Roue();
            this.sesRoues[1] = new Roue();
            this.sesRoues[2] = new Roue();
            this.sesRoues[3] = new Roue();
        }

        public Vehicule(string v)
        {
            this.v = v;
        }
    }
}
