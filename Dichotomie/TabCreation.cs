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

            Console.WriteLine("Entrez un nom pour l'ajouter à la liste:");
            Tableau_prenoms.Add(Console.ReadLine());

            do
            {
                Console.WriteLine("Entrez un nom pour l'ajouter à la liste:");
                verifie = Console.ReadLine();
                if (verifie != "")
                {
                    Tableau_prenoms.Add(verifie);
                }
            } while (verifie != "");

            Tableau_prenoms.Sort();
        }
    }
}
