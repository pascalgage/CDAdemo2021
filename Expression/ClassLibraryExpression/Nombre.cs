using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExpression
{
    public class Nombre : Expression
    {
        private int nombre;
        

        public Nombre(int _nombre)
        {
            nombre=_nombre;
        }

        public override int Evalue()
        {
            return nombre;
        }

        public override string Formate()
        {
            return nombre.ToString();
        }
    }
}
