using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCOMPTE;


namespace COMPTE_BANCAIRE
{
    public class Program
    {
        static void Main(string[] args)
        {
            COMPTE pasca = new COMPTE();

            COMPTE pascal = new COMPTE(123456, "Pascal", 700,-300);
            COMPTE david = new COMPTE(123456, "David", 200, -750);
            COMPTE doris = new COMPTE(123456, "moris", 300, -600);

            david.Transferer(95,pascal);
            david.Crediter(6000);
            david.Debiter(3000);
            david.Transferer(3700, pascal);
            pascal.AunSoldeSuperieur(david);


           
            Console.WriteLine(pascal.ToString());
            Console.WriteLine(david.ToString());



            Banque pg = new Banque("Credit Agricole", "Colmar");
            pg.AjouteCompte(123456,"DAVID",200,-750);
            pg.AjouteCompte(123456,"pascal",700,-300);
            pg.AjouteCompte(123456,"Doris",300,-600);
            pg.AjouteCompte(122345, "Richard", 702, -300);
            Console.WriteLine(pg.ToString());

            Console.WriteLine(pg.CompteSup());

            Console.ReadKey();
        }
    }
}
