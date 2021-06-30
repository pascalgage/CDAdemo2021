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
            
            Manche départ = new Manche();
            départ.LancerLes3Des();
            Console.WriteLine(départ.ToString());

            Console.ReadKey();
        }
    }
}
