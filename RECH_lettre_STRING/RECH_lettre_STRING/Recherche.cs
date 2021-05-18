using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECH_lettre_STRING
{
    class Recherche
    {
        public static int Recherche_doccurrence_dansUnePhrase(string _texteAexaminer, char _lettreAtrouve)
        {
            

            int compteurDoccurence = 0;

            

            for (int i = 0; i < _texteAexaminer.Length; i++)
            {
                if (_texteAexaminer[i] == _lettreAtrouve)
                {
                    
                    compteurDoccurence++;
                    

                }
            }

            return compteurDoccurence;
        }
    }
}
