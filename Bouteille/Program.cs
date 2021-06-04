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
            

            Bouteille mabouteille;
            mabouteille = new Bouteille();

            mabouteille.Ouvrir();
            mabouteille.RemplirTout();
            mabouteille.Vider(30);
            mabouteille.Fermer();
            mabouteille.Ouvrir();

            mabouteille.Remplir(29);
            mabouteille.Remplir(1);
            
            

            Console.WriteLine(mabouteille.ToString());

            Console.ReadKey();
        }
    }
}
