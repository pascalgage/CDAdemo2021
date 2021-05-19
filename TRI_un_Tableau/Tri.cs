using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRI_un_Tableau
{
    public class Tri
    {
        public static void Tri_à_Bulle(int[] _tableau)
        {
            int temp = 0;
            bool trie = false;

            while (trie==false)
            {
                trie = true;
                for (int i = 0; i < (_tableau.Length)-1; i++)
                {
                    if (_tableau[i] > _tableau[i + 1])
                    {
                        trie = false;
                        temp = _tableau[i];
                        _tableau[i]= _tableau[i + 1];
                        _tableau[i + 1] = temp;

                    }
                }
            }
        }
        public static void Tri_à_Bulle_LIST(List<int> _tableau)
        {
            int temp = 0;
            bool trie = false;

            while (trie == false)
            {
                trie = true;
                for (int i = 0; i < (_tableau.Count) - 1; i++)
                {
                    if (_tableau[i] > _tableau[i + 1])
                    {
                        trie = false;
                        temp = _tableau[i];
                        _tableau[i] = _tableau[i + 1];
                        _tableau[i + 1] = temp;

                    }
                }
            }
        }   }
}
