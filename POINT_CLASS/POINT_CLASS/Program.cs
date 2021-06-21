using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Point pointB;
            pointB = new Point("B",7,5);
            Console.WriteLine(pointB.ToString());
            

            Point C = pointB.ConstruireSymOrd("C");
            Console.WriteLine(C.ToString());

            

            

            
            
            


            Console.ReadKey();
        }
    }
}
