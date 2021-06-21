using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRACTION_CLASS
{
    public class Fraction
    {
        //Attributs....
        private int numerateur;
        private int denominateur;

        //Constructeur hybride...
        public Fraction(int _numerateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = 1;
        }

        //Constructeur à vide...
        public Fraction()
        {
            this.numerateur = 0;
            this.denominateur = 1;
        }

        //Constructeur Classique...
        //public Fraction(int _numerateur,int _denominateur)
        //{
        //    this.numerateur = _numerateur;
        //    this.denominateur = _denominateur;
        //}
        //Constructeur classique avec exception...
        public Fraction(int _numerateur, int _denominateur)
        {
            try
            {
                this.numerateur = _numerateur;
                this.denominateur = _denominateur;

                double uneFraction = (double)this.numerateur / this.denominateur;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Nous ne pouvons diviser par zéro" + e.Message);
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }


        }








        public override string ToString()
        {
            string chaineFraction = "";

            if (this.denominateur == 1)
            {
                chaineFraction += this.numerateur;
            }
            else
            {

                if (this.denominateur < 0)
                {
                    if (this.numerateur > 0)
                    {
                        chaineFraction += (-this.numerateur) + "/" + (-this.denominateur);
                    }
                    else
                    {
                        chaineFraction += (-this.numerateur) + "/" + (-this.denominateur);

                    }
                }
                else
                {
                    chaineFraction += this.numerateur + "/" + this.denominateur;
                }
            }

            return chaineFraction;
        }

    }
}
