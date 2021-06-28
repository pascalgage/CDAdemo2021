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
            bool recherche = false;
            int solde = 0;
            COMPTE maxiCompte = null;
            int compteur = 0;

            while (recherche==false && compteur<mesComptes.Count )
            {
                if (mesComptes[compteur].SoldeDuCompte > solde)
                {
                    solde = mesComptes[compteur].SoldeDuCompte;
                    recherche = false;
                }
                else
                {
                    maxiCompte = mesComptes[compteur];
                    compteur++;
                    recherche = true;
                }
            }
            return maxiCompte;


        }
        
        public COMPTE RendCompte(uint _unNumerodeCompte)
        {
            COMPTE recherche = new COMPTE();

            bool trouveOk=false;
            int icount = 0;
            while (trouveOk==false && icount<mesComptes.Count)
            {
                if (mesComptes[icount].NumeroCompte == _unNumerodeCompte)
                {
                    trouveOk = true;
                    recherche = mesComptes[icount];
                }
                else
                {
                    trouveOk = false;
                    icount++;
                    
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

            if (emetteur!=null && receveur!=null)
            {
                
                transfertOk =emetteur.Transferer(_montantTransfere,receveur);
                
            }
            else
            {

                transfertOk = false;
            }

            return transfertOk;
        }
    }
}
