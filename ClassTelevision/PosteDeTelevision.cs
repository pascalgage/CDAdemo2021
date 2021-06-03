using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTelevision
{
    public class PosteDeTelevision
    {
        //attributs ou champs en C#
        private bool allume;
        private int diagonal;
        //Contructeurs...

        //constructeur par défaut
        public PosteDeTelevision()
        {
            allume = false;
            diagonal = 17;
        }
        //constructeur classique
        public PosteDeTelevision(bool _allume, int _diagonal)
        {
            this.allume = _allume;
            this.diagonal = _diagonal;
        }
        //méthodes en C#

        public void Allumer()
        {
            allume = true;
        }
        public void Eteindre()
        {
            allume = false;
        }
        public override string ToString()
        {
            return base.ToString()+" allume= "+allume+" diagonal= "+diagonal;
        }
    }
}
