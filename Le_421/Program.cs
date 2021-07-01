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
            int numDe = 0;
            int combiendeDé = 0;
            
            Manche depart = new Manche();
            depart.LancerLes3Des();
            if (depart.AGagneLaManche() == true)
            {
                Console.WriteLine("YESSSS ! DU PREMIER COUP 421 !!!");
            }

            do
            {

            
            Console.WriteLine(depart.RenvoieUneRepresentationDesDes());


                if (depart.AEncoreUnLance() == true)
                {
                    Console.WriteLine("combiendeDé de dés voulez-vous relancer ?");
                    combiendeDé = int.Parse(Console.ReadLine());
                    if (combiendeDé == 3)
                    {
                        depart.LancerLes3Des();
                    }else if (combiendeDé == 2)
                    {
                        Console.WriteLine("Quel dé à relancer ?");
                        numDe = int.Parse(Console.ReadLine());
                        depart.Lancer(numDe);
                        Console.WriteLine("Quel dé à relancer ?");
                        numDe = int.Parse(Console.ReadLine());
                        depart.Lancer(numDe);
                    }
                    else
                    {
                        Console.WriteLine("Quel dé à relancer ?");
                        numDe = int.Parse(Console.ReadLine());

                        depart.Lancer(numDe);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Manche boulée !");
                    break;

                }
           
            
            if (depart.AGagneLaManche() == true)
            {
                Console.WriteLine("Chapeau Bas ! BRavo c'est421 !!!");
               
            }

            } while(depart.NbLancerCourant<=10);

            Console.ReadKey();
        }
    }
}
