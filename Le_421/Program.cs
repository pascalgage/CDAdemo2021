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
            int nbrmanche;
            Console.WriteLine("Combien de manches dans votre Partie 421 ?");
            nbrmanche = int.Parse(Console.ReadLine());
            Partie mapartie = new Partie(nbrmanche);

            mapartie.LancerLes3Des();
            Console.WriteLine(mapartie.RenvoieUneRepresentationDesDes());
            Console.WriteLine("Votre score est de : " + mapartie.ScoreCourant);

            if (mapartie.AGagneLaManche() == true)
            {
                Console.WriteLine("BRAVO du PREMIER COUP !");
                mapartie.MancheOK();
                Console.WriteLine("Votre score est de : " + mapartie.ScoreCourant);

            }

            for (int i = 0; i < nbrmanche; i++)
            {
                Console.WriteLine("MANCHE" + (i + 1));
                mapartie.LancerLes3Des();
                Console.WriteLine(mapartie.RenvoieUneRepresentationDesDes());

                while (mapartie.AEncoreUnLance() == true)
            {
                int numDe;
                int combiendeDé;
                Console.WriteLine("Combien de dés souhaitez-vous relancer ?");
                combiendeDé = int.Parse(Console.ReadLine());
                


                    if (combiendeDé == 3)
                    {
                        mapartie.LancerLes3Des();
                    }
                    else if (combiendeDé == 2)
                    {
                        Console.WriteLine("Quel dé à relancer ?");
                        numDe = int.Parse(Console.ReadLine());
                        mapartie.Lancer(numDe - 1);
                        Console.WriteLine("Quel dé à relancer ?");
                        numDe = int.Parse(Console.ReadLine());
                        mapartie.Lancer(numDe - 1);
                    }
                    else if (combiendeDé == 1)
                    {
                        Console.WriteLine("Quel dé à relancer ?");
                        numDe = int.Parse(Console.ReadLine());

                        mapartie.Lancer(numDe - 1);
                    }
                    else
                    {
                        Console.WriteLine("Erreur de saisie !!!");
                    }
                    Console.WriteLine(mapartie.RenvoieUneRepresentationDesDes());


                    if (mapartie.AGagneLaManche() == true)
                    {
                        Console.WriteLine("Chapeau Bas ! BRavo c'est421 !!!");
                        mapartie.MancheOK();
                        mapartie.LancerLes3Des();
                        Console.WriteLine(mapartie.RenvoieUneRepresentationDesDes());
                        Console.WriteLine("Votre score est de : " + mapartie.ScoreCourant);
                       
                    }
                    

                }
                mapartie.MancheJoueePerdue();
                Console.WriteLine("Votre score est de : " + mapartie.ScoreCourant);
                mapartie.Reinitialisation();

                if (mapartie.ScoreCourant == 0)
                {
                    Console.WriteLine("Partie Terminée, au revoir !");
                }
                else 
                {
                    
                    Console.WriteLine("Votre score est de : " + mapartie.ScoreCourant);
                }
                if (mapartie.PartieEstGagnee() == true)
                {
                    Console.WriteLine("Bravo PARTIE GAGNEE !!!");
                }
            }
            Console.ReadKey();
        }       
    }
}
