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
            uint index;
            int element = 1;

            uint nombreAreCH;
            
            Console.WriteLine("Entrez la taille de votre tableau, nombre de case= :");

            while (!uint.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Mauvaise saisie !");
            }
            

            int[] tableau = new int[index];

            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("Entrez le nombre " + ((element)++) + "/" + index);
                tableau[i] = int.Parse(Console.ReadLine());
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
            

            bool test = false;

            for (int i = 0; i < tableau.Length; i++)
            {
                
                if (tableau[i] == nombreAreCH)
                {
                    test = true;
                    Console.WriteLine(nombreAreCH + " se trouve à la position "+(i+1));
                   
                }
                
            }
            if (test == false)
            {
                Console.WriteLine(nombreAreCH + " n'existe pas dans le tableau");
            }

            Console.ReadKey();
        }
    }
}
