using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryVoiture;
namespace LaVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture bmw = new Voiture("mabm");
            Moteur m3 = new Moteur();

            
            bmw.Allummer();
            bmw.Demarrer();

            Console.ReadKey();
        }
    }
}
