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

            mabouteille.ViderTout();

            mabouteille.Remplir(25);

            mabouteille.Vider(5);

            mabouteille.Fermer();

            mabouteille.ViderTout();

            mabouteille.Ouvrir();

            mabouteille.ViderTout();

            Console.WriteLine(mabouteille.ToString());

            Console.ReadKey();
        }
    }
}
