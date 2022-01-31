using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExpression
{
    public abstract class Binaire :Expression
    {

        protected Binaire(Expression leftoperand, Expression rightoperand)
        {
            Leftoperand = leftoperand;
            Rightoperand = rightoperand;
        }

        
        public Expression Leftoperand { get; }
        public Expression Rightoperand { get; }


    }
}
