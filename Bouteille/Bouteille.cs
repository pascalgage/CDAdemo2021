using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
	public class Bouteille
	{
		//attributs...
		private decimal contenanceEnL;
		private decimal contenuEnPourcentage;
		private bool ouvert;

		//propriétés....
		public decimal ContenanceEnL
        {
            get { return contenanceEnL; }
            set { contenanceEnL = value; }
        }
		public decimal ContenuEnPourcentage
        {
            get { return contenuEnPourcentage; }
            set { contenuEnPourcentage = value; }
        }
		public bool Ouvert
        {
            get { return ouvert; }
            set { ouvert = value; }
        }


		//Constructeur par défaut
		public Bouteille()
		{
			this.contenanceEnL = 2;
			this.contenuEnPourcentage = 100;
			this.ouvert = false;
		}
		//constructeur classique
		public Bouteille(decimal _contenanceEnL,decimal _contenuEnPourcentage,bool _ouvert)
        {
			contenanceEnL = _contenanceEnL;
			contenuEnPourcentage = _contenuEnPourcentage;
			ouvert = _ouvert;
        }

		//Méthodes...
		public bool Fermer()
		{

			return false;
		}

		public bool Ouvrir()
		{

			return false;
		}

		/// 
		/// <param name="aRajouterEnPourcentage"></param>
		public bool Remplir(decimal aRajouterEnPourcentage)
		{

			return false;
		}

		public bool RemplirTout()
		{

			return false;
		}

		/// 
		/// <param name="aOterEnPourcentage"></param>
		public bool Vider(decimal aOterEnPourcentage)
		{

			return false;
		}

		public bool ViderTout()
		{

			return false;
		}

	}//end Bouteille

}//end namespace Bouteille