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
        private List<COMPTE> mesComptes;
        private int nbComptes;
        private string nom_banque;
        private string ville_banque;

        public List<COMPTE> MesComptes { get => mesComptes; }

        public void AjouteCompte(COMPTE _unCompte)
        {
            this.mesComptes.Add(_unCompte);
            nbComptes++;
        }
        private void AjouteCompte(uint _num,string _nom,int _solde, int _decouvertAutorise)
        {
            this.mesComptes.Add(new COMPTE(_num, _nom,_solde,_decouvertAutorise));
        }

        public Banque(string _nom_banque, string _ville_banque)
        {
            this.nom_banque = _nom_banque;
            this.ville_banque=_ville_banque;
            
        }

        public override string ToString()
        {
            return ""+nom_banque+" "+ville_banque+""+mesComptes;
        }
    }
}
