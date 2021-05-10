using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolue
{
    class Program
    {
        static void Main(string[] args)
        {
            int reel;

            Console.WriteLine("Entrez un nombre réel:");
            reel = int.Parse(Console.ReadLine());

            if (reel < 0)
            {
                reel = -(reel);
            }
            else if (reel == 0)
            {
                reel = 0;
            }
            
            //reel = Math.Abs(reel);

            Console.WriteLine(reel);

            Console.ReadKey();
        }
    }
}
