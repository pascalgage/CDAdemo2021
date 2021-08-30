using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTheathre
{
	public class Acte
	{

		//Attributs
		private List<Scene> mesScenes;
		int dureeActeEnMin;
		string nomActe;

		//Constructeur classique
		public Acte(List<Scene> mesScenes, int dureeActe, string nomActe)
		{
			this.mesScenes = new List<Scene>();
			this.dureeActeEnMin = dureeActe;
			this.nomActe = nomActe;
		}


	}
}
