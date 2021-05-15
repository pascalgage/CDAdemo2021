using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEARCH_inTAB
{
    class Class1
    {
        public static string Search_inTab(List<string> tab, string mot)
        {
            string resultat = " ";
            int compteur=0;
            List <int> position= new List<int>();


            //Début de la rechcerche dans le tableau tab en paramètre du mot en paramètre
            for (int i = 0; i < tab.Count; i++)
            {
                if (tab[i] == mot)
                {
                    compteur++;
                    position.Add(i + 1);
                }
            }
            //fin de boucle de recherche dans le tableau tab passé en paramètre
            if (tab.Count == 0)
            {
                resultat = "Le tableau est vide";
            }
            if (compteur == 0)
            {
                resultat = "L'élément recherché" + mot + " n'existe pas dans le tableau";
            }
            else if (compteur == 1)
            {
                resultat= "Lélément "+mot+" est présent une seule fois dans le tableau à la position "+position[0];
            }
            else
            {

            }

            return resultat;
        }
    }
}
