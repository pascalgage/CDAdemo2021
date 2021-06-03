using ClassTelevision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    class Program
    {
        static void Main(string[] args)
        {
            PosteDeTelevision lateledusalon;//declaration
            lateledusalon = new PosteDeTelevision();//initialisation par instanciation

            Console.WriteLine(lateledusalon.ToString());

            lateledusalon.Allumer();
            lateledusalon.Eteindre();

            Console.ReadKey();
        }
    }
}
