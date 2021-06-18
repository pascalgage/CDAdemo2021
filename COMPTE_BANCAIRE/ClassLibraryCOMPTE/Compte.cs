using System;

namespace COMPTE_BANCAIRE 
{
	public class COMPTE 
	{

		//Attributs
		private uint numeroCompte;
		private string nomProprietaire;
		private int soldeDuCompte;
		private int decouvertAutorise;

		//Constructeur par d�faut
		public COMPTE()
		{
			numeroCompte = 0000;
			nomProprietaire = "Client";
			soldeDuCompte = 0;
			decouvertAutorise = -500;
		}

		//Constructeur classique
		public COMPTE(uint _numeroCompte, string _nomProprietaire, int _soldeDuCompte, int _decouvertAutorise)
		{
			this.numeroCompte = _numeroCompte;
			this.nomProprietaire = _nomProprietaire;
			this.soldeDuCompte = _soldeDuCompte;
			this.decouvertAutorise = _decouvertAutorise;
		}


		public override string ToString()
		{

			return "Numero Cpte: "+numeroCompte+" NOM: "+nomProprietaire+" Solde: "+soldeDuCompte+" Decouvert autoris�: "+decouvertAutorise;
		}

		public bool Debiter(int montant)
		{
			bool debitPossible = false;

			if()

			return debitPossible;
		}

		public void Crediter(int montant)
		{
			this.soldeDuCompte += montant;
		}

		public bool Transferer(int montant, COMPTE _autreCompte)
		{

			return false;
		}

		public bool AunSoldeSuperieur(COMPTE _autreCompte)
		{
			bool estSUpOK = false;

            if (this.soldeDuCompte < _autreCompte.soldeDuCompte )
            {
				estSUpOK = true;
				Console.WriteLine("Le compte de "+this.nomProprietaire+" est inf�rieur � "+_autreCompte.nomProprietaire);
            }
            else
            {
				Console.WriteLine("Le compte de "+this.nomProprietaire+" est sup�rieur � "+_autreCompte.nomProprietaire);

			}

			return estSUpOK;
		}

		

	}//end COMPTE

}//end namespace CompteBancaire