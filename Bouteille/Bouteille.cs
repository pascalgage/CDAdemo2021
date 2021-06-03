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
			this.contenuEnPourcentage = 50;
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
		public override string ToString()
		{
			return base.ToString() + " contenance en L = " + contenanceEnL + " contenu en %= " + contenuEnPourcentage+" état = "+ouvert;
		}




		public bool Fermer()
		{
			ouvert = false;
			return ouvert;
			
		}

		public bool Ouvrir()
		{
			ouvert = true;
			return ouvert;
			
		}

		
		public bool Remplir(decimal aRajouterEnPourcentage)
		{
			if(ouvert==true && contenuEnPourcentage < 100)
            {
                if ((aRajouterEnPourcentage + contenuEnPourcentage) < 100)
                {
					contenuEnPourcentage += aRajouterEnPourcentage;
					return true;
                }
                else
                {
					return false;
                }
				
            }
            else
            {
				return false;
			}
			
		}

		public bool RemplirTout()
		{
			if(ouvert==true && contenuEnPourcentage < 100)
            {
				contenuEnPourcentage = 100;
				return true;
            }
            else
            {
				return false;
            }
			
		}

		/// 
		/// <param name="aOterEnPourcentage"></param>
		public bool Vider(decimal aOterEnPourcentage)
		{
			if(ouvert==true && contenuEnPourcentage <= 100)
            {
				contenuEnPourcentage -= aOterEnPourcentage;
				return true;
            }
            else
            {
				return false;
			}
			
		}

		public bool ViderTout()
		{
			if(ouvert==true && contenuEnPourcentage <= 100)
            {
				contenuEnPourcentage = 0;
				return true;
            }
            else
            {
				return false;
			}

			
		}

	}//end Bouteille

}//end namespace Bouteille