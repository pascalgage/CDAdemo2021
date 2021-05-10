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
            int nb;
            

            Console.WriteLine("Entrez le nombre de Premiers désirés:");
            nb = int.Parse(Console.ReadLine());

            List<int> r = Class1.GivePremier(nb);

            for (int i = 0; i < r.Count; i++)
            {
                Console.WriteLine(r[i]);
            }
            

            Console.ReadKey();

        }
        
        
        
    }
}
