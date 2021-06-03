using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal aRajouterEnPourcentage=50;

            Bouteille mabouteille;
            mabouteille = new Bouteille();

            mabouteille.Ouvrir();

            mabouteille.Vider(aRajouterEnPourcentage);
            
            

            Console.WriteLine(mabouteille.ToString());

            Console.ReadKey();
        }
    }
}
