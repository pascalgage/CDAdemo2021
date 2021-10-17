using ClassLibraryVOITURE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITION_OBJET
{
    public class Program
    {
        static void Main(string[] args)
        {
            Moteur rsv50 = new Moteur();
            Roue mk50 = new Roue();
            
            Vehicule maFerrari = new Vehicule("Ferrari");

            Console.ReadKey();
        }
    }
}
