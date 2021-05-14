using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassPREMIER;

namespace PREMIERNBR
{
    class Program
    {
        static void Main(string[] args)
        {
            uint nombre;
            
            bool test;

            Console.WriteLine("Entrez un nombre entier positif pour vérifier s'il est PREMIER:");
            nombre = uint.Parse(Console.ReadLine());

            test=Class1.EstUnNombrepremier(nombre);

            if (test == true) { Console.WriteLine("le nombre " + nombre + " est PREMIER"); }
            else
            {
                Console.WriteLine("le nombre " + nombre + " n'est pas PREMIER");
            }

            Console.ReadKey();


            
        }
    }
}
