using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExpression
{
    public abstract class Expression
    {
        public Expression()
        {

        }

        public abstract int Evalue();
        public abstract string Formate();
        

            
    }
}
