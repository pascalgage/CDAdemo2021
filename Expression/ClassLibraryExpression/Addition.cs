using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExpression
{
    public class Addition : Binaire
    {
        public Addition(Expression _leftoperand, Expression _rightoperand) : base(_leftoperand, _rightoperand)
        {

        }



        public override int Evalue()
        {

            return Leftoperand.Evalue()+Rightoperand.Evalue();
        }


        public override string Formate()
        {
            return (Leftoperand.Formate() + "+" + Rightoperand.Formate()) +Formate2();
        }



        //public override string Formate()
        //{
        //    return (Leftoperand.Formate() + "+" + Rightoperand.Formate()) + "=" + new Addition(Leftoperand, Rightoperand).Evalue();
        //}

        public string Formate2()
        {
            return new Addition(Leftoperand,Rightoperand).Evalue().ToString();
        }
    }
}
