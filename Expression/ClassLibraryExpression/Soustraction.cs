using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExpression
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression _leftoperand, Expression _rightoperand) : base(_leftoperand, _rightoperand)
        {

        }

        public override int Evalue()
        {
            return Leftoperand.Evalue() - Rightoperand.Evalue();
        }

        public override string Formate()
        {
            //return Leftoperand.ToString()+"+"+Rightoperand.ToString()+"="+ new Soustraction(Leftoperand,Rightoperand);
            return Leftoperand.Formate();
        }

        public override string LeftFormate()
        {
            return (Leftoperand.LeftFormate() + "-" + Rightoperand.LeftFormate());
        }
    }
}
