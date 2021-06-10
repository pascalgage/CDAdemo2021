using ClassLibrary_Lepidoptere;



namespace ClassLibrary_Lepidoptere {
	public class Lepidoptere {
		//attributs
		private StadEvolution sonStadeCourant;
		private string nom;

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
		public Lepidoptere()
		{

			this.nom = "";
			this.sonStadeCourant = new Oeuf();

		}

		public void SeDeplacer()
		{

		}

		public void SeTransformer()
		{

		}

	}//end Lepidoptere

}//end namespace Lepidoptere