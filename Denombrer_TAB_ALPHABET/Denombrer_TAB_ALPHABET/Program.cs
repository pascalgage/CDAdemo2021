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
            string[] Alphabet = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                                 "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int[] TabCount = new int[26];

            string textAexaminer;

            Console.WriteLine("Entrer votre texte:");
            textAexaminer = Console.ReadLine();
        }
    }
}
