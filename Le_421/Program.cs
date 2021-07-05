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
            Console.WriteLine("Votre score est de : " + mapartie.ScoreCourant);

            for (int i = 0; i < nbrmanche; i++)
            {
                Console.WriteLine("MANCHE " + (i + 1));
                mapartie.LancerLes3Des();
                if (mapartie.AGagneLaManche() == true)
                {
                    Console.WriteLine("BRAVO du PREMIER COUP !");
                    mapartie.MancheOK();
                    Console.WriteLine("Votre score est de : " + mapartie.ScoreCourant);

                }
                Console.WriteLine(mapartie.RenvoieUneRepresentationDesDes());

                while (mapartie.AEncoreUnLance() == true)
                {
              
                    string numdebis;

                    Console.WriteLine("Quel(s) dé(s) souhaitez-vous relancer ? Tapez le numéro du ou des dé(s) séparé par une virgule");
                    numdebis = (Console.ReadLine());
                    List<int> result = mapartie.SaisieDesNumdeDe(numdebis);
                    AnalyseSaisieUtilisateur(result,mapartie);
                    
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
                else if (mapartie.ScoreCourant > 0 && mapartie.NombreDeMancheJoue == nbrmanche)
                {
                    Console.WriteLine("Bravo PARTIE GAGNEE !!!");
                    Console.WriteLine("Votre score est de : " + mapartie.ScoreCourant);
                }
                if (mapartie.PartieEstGagnee() == true)
                {
                    Console.WriteLine("Bravo PARTIE GAGNEE !!!");
                }
            }
            Console.ReadKey();
        }
        public static void AnalyseSaisieUtilisateur(List<int> _maliste, Partie _mapartie)
        {

            

            if (_maliste.Count == 3)
            {
                _mapartie.Lancer(_maliste[0], _maliste[1], _maliste[2]);
                Console.WriteLine(_mapartie.RenvoieUneRepresentationDesDes());
            }
            else if (_maliste.Count == 2)
            {
                _mapartie.Lancer(_maliste[0], _maliste[1]);
                Console.WriteLine(_mapartie.RenvoieUneRepresentationDesDes());
            }
            else if (_maliste.Count == 1)
            {
                _mapartie.Lancer(_maliste[0]);
                Console.WriteLine(_mapartie.RenvoieUneRepresentationDesDes());
            }
        }

    }
}
