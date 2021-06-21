using System;

namespace COMPTE_BANCAIRE 
{
	public class COMPTE 
	{

		//Attributs de l'objet COMPTE

		private uint numeroCompte;
		private string nomProprietaire;
		private int soldeDuCompte;
		private int decouvertAutorise;

        //Constructeur par défaut de l'objet COMPTE

        public COMPTE()
        {
            numeroCompte = 0000;
            nomProprietaire = "Client";
            soldeDuCompte = 0;
            decouvertAutorise = -500;
        }

        //Constructeur classique de l'objet COMPTE

        public COMPTE(uint _numeroCompte, string _nomProprietaire, int _soldeDuCompte, int _decouvertAutorise)
        {
            this.numeroCompte = _numeroCompte;
            this.nomProprietaire = _nomProprietaire;
            this.soldeDuCompte = _soldeDuCompte;
            this.decouvertAutorise = _decouvertAutorise;
        }

        //Constructeur par clonage de l'objet COMPTE

        public COMPTE( COMPTE _compteArecopie)
        {
			this.numeroCompte = _compteArecopie.numeroCompte;
			this.nomProprietaire = _compteArecopie.nomProprietaire;
			this.soldeDuCompte = _compteArecopie.soldeDuCompte;
			this.decouvertAutorise = _compteArecopie.decouvertAutorise;
        }





		//Méthodes de COMPTE :

		//Réaliser l'affichage console de l'état d'un COMPTE...

		public override string ToString()
		{

			return "Numero Cpte: "+numeroCompte+" NOM: "+nomProprietaire+" Solde: "+soldeDuCompte+" Decouvert autorisé: "+decouvertAutorise;
		}

		//Débiter un compte d'un certain montant dans le respect du découvert autorisé...

		public bool Debiter(int montant)
		{
			bool debitPossible;

			if(montant <= this.soldeDuCompte - this.decouvertAutorise)
            {
				this.soldeDuCompte = this.soldeDuCompte - montant;
				debitPossible = true;
            }
            else
            {
				debitPossible = false;
            }

			return debitPossible;
		}

		//Créditer un Compte d'une certaine somme...

		public void Crediter(int montant)
		{
			this.soldeDuCompte += montant;
		}

		//Transfert une somme d'un Compte A vers un autre compte dans le respect du découvert Autorisé de A...

		public bool Transferer(int montant, COMPTE _autreCompte)
		{
			bool transfertOk = false;

            if (this.Debiter(montant) == true)
            {
				_autreCompte.Crediter(montant);
				transfertOk = true;
            }
            else
            {
				transfertOk = false;
            }

			return transfertOk;
		}

		//Comparer un compte A à un autre Compte et dire s'il lui est supérieur ou inférieur...

		public bool AunSoldeSuperieur(COMPTE _autreCompte)
		{
			bool estSUpOK = false;

            if (this.soldeDuCompte < _autreCompte.soldeDuCompte )
            {
				estSUpOK = true;
				Console.WriteLine("Le compte de "+this.nomProprietaire+" est inférieur à celui de "+_autreCompte.nomProprietaire);
            }
            else
            {
				Console.WriteLine("Le compte de "+this.nomProprietaire+" est supérieur à celui de  "+_autreCompte.nomProprietaire);

			}

			return estSUpOK;
		}
		//Changer le découvert autorisé...

		public void ChangerAutorisationDuDecouvert(int nouveauDecouvert)
        {
			this.decouvertAutorise = nouveauDecouvert;
        }

		

	}//end COMPTE

}//end namespace COMPTE_BANCAIRE