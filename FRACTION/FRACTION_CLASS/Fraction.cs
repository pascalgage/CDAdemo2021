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
        public int Denominateur { get => denominateur; }
        
        //Constructeur...
        public Fraction(int _numerateur)
        :this(_numerateur, 1)
        {
            
        }

        //Constructeur par défaut...
        public Fraction()
        :this(0,1)
        {
            
        }

        //Constructeur par recopie....
        public Fraction(Fraction _aRecopie)
        :this(_aRecopie.numerateur, _aRecopie.denominateur)
        {
            
        }

        //Constructeur classique avec exception...
        public Fraction(int _numerateur, int _denominateur)
        {
            if (_denominateur == 0)
            {
                throw new ArgumentOutOfRangeException("Le dénominateur ne peut pas être zéro");
            }

            this.numerateur = _numerateur;
            this.denominateur = _denominateur;

            
        }

        //Méthode d'affichage finale de Fraction...
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

        //Méthode qui permet d'obtenir le résultat numérique de Fraction...
        public decimal Evalue()
        {
            decimal result;
            result = Convert.ToDecimal(this.numerateur) / Convert.ToDecimal( this.denominateur);
            result = (Math.Round(result, 4));
            return result;
        }

        //Méthode de comparaison de deux fractions...
        public bool SuperieurA(Fraction _autreFraction)
        {
            bool estSup=false;

            if(this.Evalue() > _autreFraction.Evalue())
            {
                estSup = true;
            }
            else
            {
                estSup = false;
            }
            return estSup;
        }

        //Méthode de comparaison de deux fractions...
        public bool EgalA(Fraction _autreFraction)
        {
            bool estEgalA = false;
            if (this.Evalue() == _autreFraction.Evalue())
            {
                estEgalA = true;
            }
            else
            {
                estEgalA = false;
            }
            return estEgalA;
        }

        //Méthode de comparaison de deux fractions...
        public bool EstInferieurA(Fraction _autreFraction)
        {
            bool estInf = false;

            if (this.Evalue() < _autreFraction.Evalue())
            {
                estInf = true;
            }
            else
            {
                estInf = false;
            }
            return estInf;
        }

        //Méthode qui vise à calculer le PGCD d'une fraction...
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

        //Méthode de réduction de fraction...
        public void Reduire()
        {
            this.GestionSigne();
            int pgcd = this.GetPgcd();
            numerateur = numerateur / pgcd;
            denominateur = denominateur / pgcd;
        }

        //Méthode de gestion du signe de la fraction...
        public void GestionSigne()
        {
            if (denominateur < 0)
            {
                numerateur = -numerateur;
                denominateur = -denominateur;
            }

        }

        //Méthode qui vise à inverser une fraction...réutilisée dans méthode Divise()...
        public void Inverse()
        {
            int temp = this.numerateur;
            this.numerateur = this.denominateur;
            this.denominateur = temp;
        }

        //Addition.
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

        //Soustraction.
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

        //Multiplication.
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
        
    }//Fin de la Classe Fraction
}//Fin du namespace FRACTION_CLASS
