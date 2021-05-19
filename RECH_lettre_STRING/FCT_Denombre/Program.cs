using RECH_lettre_STRING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCT_Denombre
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration de variables
            string textAexaminer = "";//que l'on convertira en tableau de caractères

            //création du compteur d'occurences...
            int[] tableauComptage = new int[26];

            //création du tableau Alphabétique de comparaison...
            char[] alphabet = new char[26];
            char A = 'a';

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = A;
                A++;
            }

            //création et mise en mémoire d'un texte utilisateur en minuscule
            Console.WriteLine("Veuillez entrer votre texte:");
            textAexaminer = Console.ReadLine().ToLower();



            //boucle for ou on appelle la fonction Recherche pour chaque lettre
            int resultat = 0;

            for (int i = 0; i < alphabet.Length; i++)
            {
               resultat= Recherche.Recherche_doccurrence_dansUnePhrase(textAexaminer, alphabet[i]);
               tableauComptage[i] = resultat;
            }

            //affichage
            for (int i = 0; i < tableauComptage.Length; i++)
            {
                if (tableauComptage[i] != 0)
                {
                    Console.WriteLine(alphabet[i]+":"+tableauComptage[i]);
                }
                
            }
            
            //Console.WriteLine(alphabet[i] + ":" + resultat);

            Console.ReadKey();
        }
    }
}
