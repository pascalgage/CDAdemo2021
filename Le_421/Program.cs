using Class_libray_421;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_421
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Manche depart = new Manche();
            
            
            Console.WriteLine(depart.RenvoieUneRepresentationDesDes());
            int numDe = 0;
            Console.WriteLine("Quel dé à relancer ?");
            numDe = int.Parse(Console.ReadLine());

            depart.Lancer(numDe);

            Console.WriteLine(depart.RenvoieUneRepresentationDesDes());

            if (depart.AGagneLaManche() == true)
            {
                Console.WriteLine("Chapeau Bas ! BRavo c'est421 !!!");
            }

            Console.ReadKey();
        }
    }
}
