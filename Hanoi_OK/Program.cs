using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_OK
{
    class Program
    {
        static void Main(string[] args)
        {
            string tA = "12345";
            string tB = "";
            string tC = "";
            Hanoi_Try.Transfert(tA.Length, ref tA, ref tC, ref tB);
            Console.WriteLine("" + tA + "");
            Console.WriteLine("" + tB + "");
            Console.WriteLine("" + tC + "");

            Console.ReadKey();
        }
    }
}
