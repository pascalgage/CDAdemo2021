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
        private int nbrComptes;
        private string nom_banque;
        private string ville_banque;

        //Constructeur de l'objet Banque....
        public Banque(string _nom_banque, string _ville_banque)
        {
            nom_banque = _nom_banque;
            ville_banque = _ville_banque;
            mesComptes = new List<COMPTE>();
            nbrComptes = 0;

        }


        //Méthodes de l'objet Banque...


        private void AjouteCompte(COMPTE _unCompte)
        {
            mesComptes.Add(_unCompte);
            nbrComptes++;
        }

        public void AjouteCompte(uint _numeroCompte, string _nomProprietaire, int _soldeDuCompte, int _decouvertAutorise)
        {
            COMPTE nouveauCompte = new COMPTE(_numeroCompte, _nomProprietaire, _soldeDuCompte, _decouvertAutorise);
            AjouteCompte(nouveauCompte);
        }

        //méthode à refaire d'urgence avec AunSoldeSuperieur de compte.cs!
        public COMPTE CompteSup()
        {
            int comptesolde = 0;
            COMPTE maxiCompte=null;

            for (int i = 0; i < mesComptes.Count; i++)
            {
                if(mesComptes[i].SoldeDuCompte > comptesolde)
                {
                    comptesolde = mesComptes[i].SoldeDuCompte;
                    maxiCompte = mesComptes[i];
                }
            }
            return maxiCompte;
        }

        public COMPTE RendCompte(uint _unNumerodeCompte)
        {
            COMPTE recherche = null;

            for (int i = 0; i < mesComptes.Count; i++)
            {
                if (mesComptes[i].NumeroCompte == _unNumerodeCompte)
                {
                    recherche = mesComptes[i];
                }
                
            }
            
            return recherche;
        }

        public override string ToString()
        {
            string lesComptes="";

            lesComptes= " "+nom_banque+" "+ville_banque+":"+"\n" + lesComptes;

            for (int i = 0; i <nbrComptes; i++)
            {
                lesComptes += mesComptes[i].ToString() + "\n";
            }

            return lesComptes;
        }

        public bool Transferer(uint _compteEmetteur,uint _compteReceveur, int _montantTransfere)
        {
            bool transfertOk;
            COMPTE emetteur = RendCompte(_compteEmetteur);
            COMPTE receveur = RendCompte(_compteReceveur);

            if (emetteur.Debiter(_montantTransfere)==true)
            {
                
                emetteur.Transferer(_montantTransfere,emetteur);
                receveur.Crediter(_montantTransfere);
                transfertOk = true;
            }
            else
            {

                transfertOk = false;
            }

            return transfertOk;
        }
    }
}
