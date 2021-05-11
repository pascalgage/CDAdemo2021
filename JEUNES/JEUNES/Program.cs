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
            int[] jeunes = new int[20]; //Déclaration du tableau de vingt personnes

            for (int i = 0; i < jeunes.Length; i++) //Création du tableau par la saisie des âges
            {
                Console.WriteLine("Entrez l'âge de la personne n°" + (i + 1)); //On propose de rentrer l'âge de la personne n° tel...
                jeunes[i] = int.Parse(Console.ReadLine()); //on contrôle que les saisies soient bien des entiers positifs...
            }
            int moinsdevingt = 0; // j'initialise la variable moinsdevingt qui servira de compteur...

            for (int i = 0; i < jeunes.Length; i++)// on parcoure le tableau et on repère tous les éléments inférieurs à 20
            {
                if (jeunes[i] < 20)
                {
                    moinsdevingt++; //la variable est incrémenté à chaque passage dans le if
                }
            }

            Console.WriteLine("Les personnes ayant moins de vingt ans sont au nombre de : "+ moinsdevingt);

            Console.ReadKey();
        }
    }
}
