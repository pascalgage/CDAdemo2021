﻿using Class_libray_421;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Le_421
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Création du nom du joueur....
            string nomjoueur;
            LesJoueurs listef = new LesJoueurs();
            Console.WriteLine("Entrez le nom du joueur:");
            nomjoueur = Console.ReadLine();
            //Demande du nombre de manches...
            int nbrmanche;
            Console.WriteLine("Combien de manches dans votre Partie 421 ?");
            nbrmanche = int.Parse(Console.ReadLine());
            Partie mapartie = new Partie(nbrmanche);
            Console.WriteLine("Votre score est de : " + mapartie.ScoreCourant);
            //Score du joueur ajouter à la liste...
            int scorejoueur=mapartie.ScoreCourant;
            listef.AjouterUnJoueur(nomjoueur, scorejoueur);

            Serialization.Sauvegarder(listef);

            List<Joueur> ma_liste= Serialization.Ouvrir();

            for (int i = 0; i < ma_liste.Count; i++)
            {
                Console.WriteLine(" NOM : " + ma_liste[i].Nom + " SCORE : " + ma_liste[i].Score);
            }


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

                    Console.WriteLine("Quel(s) dé(s) souhaitez-vous relancer ? Tapez le numéro du ou des dé(s) séparé par une virgule,ou un espace:");
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
            //Serialization....de l'objet créer en début de programme: listef
            //BinaryFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream("C:\\1CDA\\CDAdemo2021\\Le_421\\Paskytest.txt", FileMode.Create, FileAccess.Write);

            //formatter.Serialize(stream, listef);
            //stream.Close();
            /// fin de la sérialization
          

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
