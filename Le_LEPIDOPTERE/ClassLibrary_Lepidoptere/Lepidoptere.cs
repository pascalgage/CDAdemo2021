using ClassLibrary_Lepidoptere;



namespace ClassLibrary_Lepidoptere {
	public class Lepidoptere {
		//attributs
		private string nom;
		private StadEvolution sonStadeCourant;
		

		//propriétés
		public string Nom { get => nom; }
		public StadEvolution SonStadeCourant { get => sonStadeCourant; }

		//Constructeur classique
		public Lepidoptere(string _nom, StadEvolution _sonStadeCourant)
		{

			this.nom = _nom;
			this.sonStadeCourant = _sonStadeCourant;

		}
		//constructeur par défaut
		public Lepidoptere(string _nom)
		{

			this.nom = _nom;
			this.sonStadeCourant = new Oeuf();

		}

		public void SeDeplacer()
		{
			sonStadeCourant.SeDeplacer();
		}

		//public void SeTransformer()
		//{
		//	if (sonStadeCourant is Oeuf)
		//          {
		//		sonStadeCourant = new Chenille();
		//          }
		//          else if (sonStadeCourant is Chenille)
		//          {
		//		sonStadeCourant = new Chrisalyde();
		//          }

		//          else if (sonStadeCourant is Papillon)
		//          {
		//		sonStadeCourant = new Papillon();
		//          }
		//      }

		public void SeTransformer()
		{
		
			sonStadeCourant = sonStadeCourant.DonneLeProchainStade();
		}

	}//end Lepidoptere

}//end namespace Lepidoptere