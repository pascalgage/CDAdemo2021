using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIBULLE
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] tableau = new int[5];
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("Veuillez saisir l'âge de la personne n° :" + (i + 1));
                tableau[i] = int.Parse(Console.ReadLine());
            }

            Tri_Bull(tableau);

            Console.WriteLine("Les chiffres triés dans l'ordre croissant sont :");
            foreach (var item in tableau)
            {
                
                Console.Write(" "+item+" ");
            } 

            Console.ReadKey();

        }
        public static void Tri_Bull(int[] _Tab)
        {
            int temp = 0;
            bool tri= false;

            while (tri == false)
            {
                tri = true;
                for (int i = 0; i < _Tab.Length-1; i++)
                {
                    if (_Tab[i] > _Tab[i + 1])
                    {
                        tri = false;
                        temp = _Tab[i];
                        _Tab[i] = _Tab[i + 1];
                        _Tab[i + 1] = temp;
                    }
                   
                }
            }

        }
        //fin de la méthode de tri à bulle (While)
    }
}
