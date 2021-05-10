using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQUATION
{
    public class Program
    {
        static void Main(string[] args)
        {
            float a;
            
            float b;

            float equation;

            Console.WriteLine("Entrez une valeur pour a:");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Entrez une valeur pour b:");
            b = float.Parse(Console.ReadLine());

            equation= Calcul_EQ(a, b);//appel de la méthode...

            Console.WriteLine(equation);

            Console.ReadKey();
        }

        public static float Calcul_EQ(float _a, float _b)
        {
            float equation;

            if (_a == 0 && _b != 0)
            {
                throw new Exception("Equation invalide!");
            }
            if (_a == 0 && _b == 0)
            {
                throw new Exception("Equation impossible!");
            }
            equation = -_b / _a;

            return equation;
        }
    }
}
