using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEUNES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration du tableau de vingt personnes
            int[] jeunes = new int[20];


            //Création du tableau par la saisie des âges
            for (int i = 0; i < jeunes.Length; i++)
            {
                Console.WriteLine("Entrez l'âge de la personne n°" + (i + 1)); //On propose de rentrer l'âge de la personne n° tel...
                jeunes[i] = int.Parse(Console.ReadLine()); //on contrôle que les saisies soient bien des entiers positifs...
            }


            // j'initialise la variable moinsdevingt qui servira de compteur...
            int moinsdevingt = 0;



            // on parcoure le tableau et on repère tous les éléments inférieurs à 20
            for (int i = 0; i < jeunes.Length; i++)
            {
                if (jeunes[i] < 20)
                {
                    moinsdevingt++; //la variable est incrémenté à chaque passage dans le if
                }
            }
            if (moinsdevingt == 0)
            {
                Console.WriteLine("Toutes les personnes ont plus de vingt ans");
            }
            else if (moinsdevingt == jeunes.Length)
            {
                Console.WriteLine("Toutes les personnes ont moins de vingt ans");
            }

            Console.WriteLine("Les personnes ayant moins de vingt ans sont au nombre de : "+ moinsdevingt);

            Console.ReadKey();
        }
    }
}
