using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryVoitureTH;
namespace LAvoitureTH
{
    public class Program
    {
        static void Main(string[] args)
        {
            Voiture bmw = new Voiture();
            bmw.Avancer();
            

            Console.ReadKey();
        }
    }
}
