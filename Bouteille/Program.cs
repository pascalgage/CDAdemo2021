using NS_Bouteille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Bouteille
{
    public class Program
    {
        static void Main(string[] args)
        {

            Bouteille b = new Bouteille();
            b.Estouvertpourlapremierefois += B_Estouvertpourlapremierefois;
            

            Console.ReadKey();
        }

        private static void B_Estouvertpourlapremierefois(decimal _contenanceEnL)
        {
            Console.WriteLine("glouglou");
        }
    }
}
