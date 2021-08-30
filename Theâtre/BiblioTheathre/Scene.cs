using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTheathre
{
    public class Scene
    {
		//attributs

		private string nomScene;
		private int dureeSceneEnMin;

		//Constructeur classique
		public Scene(string _nomScene, int _duree)
		{
			this.nomScene = _nomScene;
			this.dureeSceneEnMin = _duree;
		}
		//Constructeur par interdépendance (recopie)
		public Scene(Scene _SceneARECOP)
			: this(_SceneARECOP.nomScene, _SceneARECOP.dureeSceneEnMin)
		{

		}
	}
}
