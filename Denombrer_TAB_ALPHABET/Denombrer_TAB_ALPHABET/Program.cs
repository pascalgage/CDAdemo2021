using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrer_TAB_ALPHABET
{
    class Program
    {
        static void Main(string[] args)
        {
            string textAexaminer = "";


            //création du tableau Alphabétique de comparaison...
            char[] Alphabet = new char[26];
            char A = 'a';

            for (int i = 0; i < Alphabet.Length; i++)
            {
                Alphabet[i] = A;
                A++;
            }
            //création du compteur d'occurences...
            int[] tableauComptage = new int[26];

            //création et mise en mémoire d'un texte utilisateur en minuscule
            Console.WriteLine("Entrer votre texte:");
            textAexaminer = Console.ReadLine().ToLower();

            //on convertit le texte en tableau de caractères en vue de la comparaison avec tableau Alphabet
            char[] textAexaminerX = textAexaminer.ToCharArray();

            //on effectue la comparaison du tableau de caractère du texte utilisateur avec notre Alphabet
            for (int i = 0; i < Alphabet.Length; i++)
            {
                foreach (char ALPHA in textAexaminerX)
                {

                    if (Alphabet[i] == ALPHA)
                    {
                        tableauComptage[i]++;
                    }

                }
            }
            //Affichage du résultat final...
            for (int i = 0; i < tableauComptage.Length; i++)
            {
                if (tableauComptage[i] != 0)
                {
                    Console.WriteLine(Alphabet[i] + " : " + tableauComptage[i]);
                }
            }

            Console.ReadKey();

        }
    }
}
