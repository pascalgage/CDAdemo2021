///////////////////////////////////////////////////////////
//  Chenille.cs
//  Implementation of the Class Chenille
//  Generated by Enterprise Architect
//  Created on:      09-juin-2021 11:42:48
//  Original author: pasca
///////////////////////////////////////////////////////////




using ClassLibrary_Lepidoptere;
using System;

namespace ClassLibrary_Lepidoptere
{
	public class Chenille : StadEvolution {

		public Chenille(){

		}

		public override void SeDeplacer()
		{
			Console.WriteLine("Je rampe");
		}
		public override StadEvolution DonneLeProchainStade()
		{
			return new Chrisalyde();
		}



	}//end Chenille

}//end namespace Lepidoptere