﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECH_TAB_nbr
{
    class Class1
    {
        public static void Tri_Bull(uint[] _Tab)
        {
            uint temp = 0;
            bool tri = false;

            while (tri == false)
            {
                tri = true;
                for (int i = 0; i < _Tab.Length - 1; i++)
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

        public static string Search_aNUM(uint[] _monTab, uint _monNBR)
        {
            string resultat=" ";
            
            bool test = false;

            for (int i = 0; i < _monTab.Length; i++)
            {

                if (_monTab[i] == _monNBR)
                {
                    test = true;
                    resultat=(_monNBR + " se trouve à la position " + (i + 1));

                }

            }
            if (test == false)
            {
                resultat=(_monNBR + " n'existe pas dans le tableau");
            }

            return resultat;
        }

        public static bool Recherche_delaposition_dunNombredans_unTableau(uint[] _tableau, uint _nombreRecherche, out int _position)
        {
            bool atrouve=false;

            int compteur = 0;
            _position = -1;
           

            while (atrouve == false && compteur < _tableau.Length)
            {

                if (_tableau[compteur] == _nombreRecherche)
                {
                    atrouve = true;
                    _position = compteur;
                   

                }
                else
                {

                    atrouve = false;
                    
                }
                compteur++;
            }

            return atrouve;
        }

        public static bool Search_While(uint[] _monTab, uint _monNBR, ref int _index)
        {
            bool test2 = false;
            int compt = 0;

 

            while (test2 == false && compt < _monTab.Length)
            {
                if (_monTab[compt] == _monNBR)
                {
                    test2 = true;
                    _index = compt;
                }
                compt++;
            }
            return test2;
        }
    }
}
