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

        public int Numerateur { get => numerateur;  }
        public int Denominateur { get => denominateur; set => denominateur =value; }
        


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
        //Constructeur par recopie....
        public Fraction (Fraction a_recopie)
        {
            this.numerateur = a_recopie.numerateur;
            this.denominateur = a_recopie.denominateur;
        }

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
            if (denominateur == 1 || numerateur==0)
            {
                return numerateur.ToString();
            }
            else
            {
                return numerateur + "/" + denominateur;
            }

        }

        private decimal Evalue(decimal n, decimal d)
        {
            decimal resultN;
            resultN = n / d;
            resultN = (Math.Round(resultN, 4));
            return resultN;
        }

        public bool SuperieurA(Fraction _autreFraction)
        {
            bool estSup=false;

            if(this.Evalue(this.numerateur, this.denominateur) > _autreFraction.Evalue(_autreFraction.numerateur, _autreFraction.denominateur))
            {
                estSup = true;
            }
            else
            {
                estSup = false;
            }
            return estSup;
        }
        
        public bool EgalA(Fraction _autreFraction)
        {
            bool estEgalA = false;
            if (this.Evalue(this.numerateur, this.denominateur) == _autreFraction.Evalue(_autreFraction.numerateur, _autreFraction.denominateur))
            {
                estEgalA = true;
            }
            else
            {
                estEgalA = false;
            }
            return estEgalA;
        }

        public bool EstInferieurA(Fraction _autreFraction)
        {
            bool estInf = false;

            if (this.Evalue(this.numerateur, this.denominateur) < _autreFraction.Evalue(_autreFraction.numerateur, _autreFraction.denominateur))
            {
                estInf = true;
            }
            else
            {
                estInf = false;
            }
            return estInf;
        }

        public int GetPgcd()
        {
            //Méthode "Last" recherche PGCD.
            List<int> tab = new List<int>();


            int numerateur = this.numerateur;
            int denominateur = this.denominateur;

            
            if (numerateur < 0)
            {
                numerateur = -numerateur;
            }

            if (denominateur < 0)
            {
                denominateur = -denominateur;
            }

            int D = 0;

            do
            {

                D++;

                if (numerateur % D == 0 && denominateur % D == 0)
                {
                    tab.Add(D);
                }

            } while (D < numerateur && D < denominateur);

            return tab.Last();


        }

        public void Reduire()
        {
            
          if (denominateur < 0)
           {
             numerateur = -numerateur;
             denominateur = -denominateur;
           }

            int pgcd = this.GetPgcd();
            numerateur = numerateur / pgcd;
            denominateur = denominateur / pgcd;
        }

        public void GestionSigne()
        {
            
            if (denominateur < 0)
            {
                numerateur = -numerateur;
                denominateur = -denominateur;
            }
            
        }

        public void Inverse()
        {
            int temp = this.numerateur;
            this.numerateur = this.denominateur;
            this.denominateur = temp;
        }

        public Fraction Plus(Fraction _autreFrac)
        {
            int n;
            int d;
            n = (this.numerateur * _autreFrac.denominateur) + (_autreFrac.numerateur * this.denominateur);
            d = (this.denominateur * _autreFrac.denominateur);

            Fraction p;
            p = new Fraction(n, d);
            p.Reduire();
            return p;
        }

        public Fraction Moins(Fraction _autreFrac)
        {
            int n;
            int d;
            n = (this.numerateur * _autreFrac.denominateur) - (_autreFrac.numerateur * this.denominateur);
            d = (this.denominateur * _autreFrac.denominateur);

            Fraction p;
            p = new Fraction(n, d);
            p.Reduire();
            return p;
        }

        public Fraction Multiplie(Fraction _autreFrac)
        {
            Fraction t = new Fraction((this.numerateur * _autreFrac.numerateur), (this.denominateur * _autreFrac.denominateur));
            t.Reduire();
            return t;
        }

        //pour la méthode Divise nous utiliserons Inverse() et le clonage....

        public Fraction Divise(Fraction _autreFrac)
        {
            Fraction t;
            Fraction clonee = new Fraction(_autreFrac);
            clonee.Inverse();
            t=this.Multiplie(clonee);

            t.Reduire();
            return t;
        }
        
        

    }
}
