using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRI_un_Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration de la variable taille du tableau
            int tailleTableau=0;
            //On demande à l'utilisateur d'entrer la taille du tableau désiré
            Console.WriteLine("Entrez la taille de votre tableau:");
            tailleTableau = int.Parse(Console.ReadLine());
            //déclaration puis instanciation du tableau désiré
            int[] tableau = new int[tailleTableau];
            //Remplissage du tableau...
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("Entrez le nombre "+(i + 1)+"/"+tailleTableau+ " de votre tableau: ");
                tableau[i] = int.Parse(Console.ReadLine());
            }
            //Affichage du tableau non trié
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write(" "+tableau[i]+" ");
            }
            //Traîtement par appel de la fonction tri à bulle
            Tri.Tri_à_Bulle(tableau);
            //Affichage du résultat...

            Console.WriteLine(" ");
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write(" " + tableau[i] + " ");
            }

            Console.ReadKey();
            
        }
    }
}
