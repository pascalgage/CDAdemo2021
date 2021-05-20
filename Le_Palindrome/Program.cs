using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase;
            int indiceLettre = 0;
            bool palindrome = true;


            Console.WriteLine("Entrez une phrase ou un mot pour voir s'il s'agit d'un palindrome:");
            phrase = Console.ReadLine();

         

            while (palindrome==true && indiceLettre<(phrase.Length/2))
            {

                indiceLettre++;

                if ((phrase[indiceLettre] == phrase[phrase.Length - 1 - indiceLettre]))
                {
                    palindrome = true;
                   
                }
                else
                {
                    palindrome = false;
                    
                }
                
            }

            if (palindrome == true)
            {
                Console.WriteLine("C'est un palindrome !");
            }
            else
            {
                Console.WriteLine("Ce n'est pas un palindrome !");
            }

            Console.ReadKey();
        }
    }
}
