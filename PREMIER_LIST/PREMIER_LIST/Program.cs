using ClassPREMIER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PREMIER_LIST
{
    public class Program
    {
        static void Main(string[] args)
        {
            uint nb;
            

            Console.WriteLine("Entrez le nombre de Premiers désirés:");
            nb = uint.Parse(Console.ReadLine());

            List<uint> r = Class1.DonneLesPremiers(nb);

            for (int i = 0; i < r.Count; i++)
            {
                Console.WriteLine(r[i]);
            }
            

            Console.ReadKey();

        }
        
        
        
    }
}
