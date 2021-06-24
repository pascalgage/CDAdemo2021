using COMPTE_BANCAIRE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCOMPTE
{
    public class Banque
    {
        private COMPTE[] mesComptes;
        private int nbrComptes;
        private string nom_banque;
        private string ville_banque;

        //Constructeur de l'objet Banque....
        public Banque(string _nom_banque, string _ville_banque)
        {
            this.nom_banque = _nom_banque;
            this.ville_banque = _ville_banque;
            mesComptes = new COMPTE[20];
            this.nbrComptes = 0;

        }


        //Méthodes de l'objet Banque...

        public void AjouteCompte(COMPTE _unCompte)
        {
            this.mesComptes[nbrComptes]=_unCompte;
            nbrComptes++;
        }


        public override string ToString()
        {
            string lesComptes;

            lesComptes= " "+nom_banque+" "+ville_banque+":";

            for (int i = 0; i < this.nbrComptes; i++)
            {
                lesComptes += this.mesComptes[i].ToString() + "\n";
            }

            return lesComptes;
        }
    }
}
