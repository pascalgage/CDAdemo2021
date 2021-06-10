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

		public void SeTransformer()
		{
			sonStadeCourant.DonneLeProchainStade();
		}

	}//end Lepidoptere

}//end namespace Lepidoptere