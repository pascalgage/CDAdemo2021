using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFizz
{
    public class Calcul
    {
        public static void Fizzbuzz(List<int> maListe)
        {


            for(int i = 0; i < maListe.Count; i++)
            {
                if(maListe[i]%5==0 && maListe[i] % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if (maListe[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if (maListe[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(maListe[i]);
                }
            }



        }
        public static List<int> KreaList(int max)
        {
            List<int> liste = new List<int>();

            for(int i=1; i <= max; i++)
            {
                liste.Add(i);
            }
            return liste;
        }
    }
}
