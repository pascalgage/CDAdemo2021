using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPTE_BANCAIRE
{
    public class Program
    {
        static void Main(string[] args)
        {
            COMPTE pasca = new COMPTE();

            COMPTE pascal = new COMPTE(23456, "Pascal", 700,-300);
            COMPTE david = new COMPTE(123456, "David", 200, -750);
            
            david.Transferer(95,pascal);
            david.Crediter(6000);
            david.Debiter(3000);
            david.Transferer(3700, pascal);
            pascal.AunSoldeSuperieur(david);


            pascal.ChangerAutorisationDuDecouvert(-700);
            Console.WriteLine(pascal.ToString());
            Console.WriteLine(david.ToString());

            Console.ReadKey();
        }
    }
}
