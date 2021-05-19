using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRI_un_Tableau;

namespace TRI_une_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration et instanciation des variables
            List<int> Listing = new List<int>();
            bool finish = false;
            int nombre;
            string decisionSaisie="n";

            while (finish==false && decisionSaisie=="n")
            {
                
                Console.WriteLine("Entrez vos nombres dans la liste:");
                nombre = int.Parse(Console.ReadLine());

                Listing.Add(nombre);

                Console.WriteLine("Saisie OK ? o/n");
                decisionSaisie = Console.ReadLine();

                if (decisionSaisie == "o")
                {
                    finish = true;
                    Console.WriteLine("Nous procédons au traîtement de vos saisies");
                }
                

            }
            Tri.Tri_à_Bulle_LIST(Listing);

            Console.WriteLine("Votre liste de nombres triés en ordre croissant est :");
            for (int i = 0; i < Listing.Count; i++)
            {
                Console.Write(" "+Listing[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
