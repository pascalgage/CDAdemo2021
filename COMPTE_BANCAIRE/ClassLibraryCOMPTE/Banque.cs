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


        private void AjouteCompte(uint _num,string _nom,int _solde, int _decouvertAutorise)
        {
            this.mesComptes.Add(new COMPTE(_num, _nom,_solde,_decouvertAutorise));
        }

        

        public override string ToString()
        {
            return ""+nom_banque+" "+ville_banque+""+mesComptes;
        }
    }
}
