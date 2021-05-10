using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour_Semaine
{
    public class Program
    {
        static void Main(string[] args)
        {
            int jour;
            int mois;
            int annee;
            

            Console.WriteLine("Entrez le jour:");
            jour = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le mois:");
            mois = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez l'année en 00 et 99 (1901 et 1999):");
            annee = int.Parse(Console.ReadLine());

            string resJour = Calcul_REST7(jour, mois, annee);

            Console.WriteLine(resJour);

            Console.ReadKey();
        }
        public static string JOUR(int _jour)
        {
            string jour_lettre;

            switch (_jour)
            {
                case 1: jour_lettre = "Dimanche";
                    break;
                case 2: jour_lettre = "Lundi";
                    break;
                case 3: jour_lettre = "Mardi";
                    break;
                case 4: jour_lettre = "Mercredi";
                    break;
                case 5: jour_lettre = "Jeudi";
                    break;
                case 6: jour_lettre = "Vendredi";
                    break;
                case 0: jour_lettre = "Samedi";
                    break;
                default:
                    throw new Exception("code incorrect");
            }

            return jour_lettre;
        }
        public static int MOIS(int _mois, int annee)
        {
            int valeur_mois;
           

            switch (_mois)
            {

                case 1:
                    if (DateTime.IsLeapYear(annee))
                        valeur_mois = 0;
                    else
                        valeur_mois = 1;
                    

                    break;
                case 2:
                    if (DateTime.IsLeapYear(annee))
                        valeur_mois = 3;
                    else
                        valeur_mois = 4;

                    break;
                case 3: valeur_mois = 4;
                    break;
                case 4: valeur_mois = 0;
                    break;
                case 5: valeur_mois = 2;
                    break;
                case 6: valeur_mois = 5;
                    break;
                case 7: valeur_mois = 0;
                    break;
                case 8: valeur_mois = 3;
                    break;
                case 9: valeur_mois = 6;
                    break;
                case 10: valeur_mois = 1;
                    break;
                case 11: valeur_mois = 4;
                    break;
                case 12: valeur_mois = 6;
                    break;
                default: throw new Exception("Saisi mois incorrect");
                
            }
            return valeur_mois;
        }
        public static string Calcul_REST7(int _jour, int _mois, int _annee)
        {
            int resultat4=_annee/4;
            int Mois = MOIS(_mois, _annee);//appel de la méthode MOIS...

            int resultat = (_annee + resultat4 + Mois + _jour) % 7;
            string Reste7 = JOUR(resultat);
            return Reste7;
        }
        public static List<int> Test(int _jour,int _annee)
        {

            List <int> TestMois = new List<int>();


            if (_jour <= 0 || _jour > 31)
            {
                throw new Exception("Saisie incorrecte");
            }else if(_jour==29 && _annee % 4 == 0)
            {
                TestMois = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12};
            }else if (_jour == 31)
            {
                TestMois = new List<int>() { 1,3,5,7,8,10,12};
            }
            else if (_jour == 30)
            {
                TestMois = new List<int>() {1,3,4,5,6,7,8,9,10,11,12};
            }
            else if(_jour <= 28)
            {
                TestMois = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            }

            return TestMois;
        }
    }
}
