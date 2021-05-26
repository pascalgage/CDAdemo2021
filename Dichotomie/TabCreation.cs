using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dichotomie
{
    public class TabCreation
    {
        public static void CreeTab(out List<string> Tableau_prenoms)
        {
            string verifie="";
            Tableau_prenoms = new List<string>();

            while (verifie != "stop") { 
            
                Console.WriteLine("Entrez un nom pour l'ajouter à la liste 'stop'+ Entrée pour arrêter la saisie:");
                verifie = Console.ReadLine();
                if (verifie != "stop")
                {
                    Tableau_prenoms.Add(verifie);
                }

            }
            Tableau_prenoms.Sort();
        }


        public static string Verif_tableau(List<string> _tableau, string _prenom)
        {
            string resultatdeRecherche = "";
            int compteur = 0;
            List<int> position = new List<int>();

            for (int i = 0; i < _tableau.Count; i++)
            {
                if (_tableau[i] == _prenom)
                {
                    compteur++;
                    position.Add(i + 1);
                }
            }
            //fin de la procédure de recherche initiale...

            if (_tableau.Count == 0)
            {
                resultatdeRecherche = "Le tableau est vide!";
            }
            if (compteur == 0)
            {
                resultatdeRecherche = "L'élément recherché n'est pas présent dans le tableau!!";
            }
            else if(compteur==1)
            {
                resultatdeRecherche = "L'élément " + _prenom + " apparaît une fois dans le tableau à la position " + position[0];
            }
            else
            {
                resultatdeRecherche = "L'élément apparaît " + compteur + " fois dans le tableau aux positions:";
                for (int j = 0; j < position.Count; j++)
                {
                    resultatdeRecherche += position[j] + " , ";
                }
                resultatdeRecherche += "Il s'agit de doublons !";
            }

            return resultatdeRecherche;
        }
    }
}
