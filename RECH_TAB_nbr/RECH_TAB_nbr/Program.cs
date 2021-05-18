using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECH_TAB_nbr
{
    class Program
    {
        static void Main(string[] args)
        {
            uint index = 0;
            int element = 1;
            uint nombreAreCH;
           

            Console.WriteLine("Entrez la taille de votre tableau, nombre de case= :");

            while (!uint.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Mauvaise saisie !");
            }

            
            uint[] tableau = new uint[index];
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("Entrez le nombre " + ((element)++) + "/" + index);
                tableau[i] = uint.Parse(Console.ReadLine());
            }

            Class1.Tri_Bull(tableau);

            foreach (var item in tableau)
            {
                Console.Write(" " + item + " ");
            }

            Console.WriteLine("Entrez le nombre à rechercher:");
            while (!uint.TryParse(Console.ReadLine(), out nombreAreCH))
            {
                Console.WriteLine("Mauvaise saisie !");
            }
            int position;

            bool atrouve=Class1.Recherche_delaposition_dunNombredans_unTableau(tableau, nombreAreCH, out position);
            if (atrouve == true)
            {
                Console.WriteLine("Le nombre recherché est à la position :"+(position+1)); //position +1 pour l'affichage de la position tableau à l'utilisateur
            }
            else
            {
                Console.WriteLine("Le nombre recherché n'est pas dans le tableau !");
            }
            

            Console.ReadKey();
        }
    }
}
