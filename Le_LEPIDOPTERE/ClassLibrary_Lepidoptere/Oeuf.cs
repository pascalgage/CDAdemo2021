///////////////////////////////////////////////////////////
//  Oeuf.cs
//  Implementation of the Class Oeuf
//  Generated by Enterprise Architect
//  Created on:      09-juin-2021 11:42:32
//  Original author: pasca
///////////////////////////////////////////////////////////




using ClassLibrary_Lepidoptere;
using System;

namespace ClassLibrary_Lepidoptere
{
	public class Oeuf : StadEvolution {

		public Oeuf()
		{

		}

		public override StadEvolution DonneLeProchainStade()
		{
			return new Chenille();
		}

        public override void SeDeplacer()
		{
			Console.WriteLine("Je ne sais pas me d�placer");
		}
       

    }//end Oeuf

}//end namespace Lepidoptere