﻿using System;
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
        //public Fraction(int _numerateur, int _denominateur)
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

            if (this.denominateur == 1| this.denominateur==0)
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

            //int a = numerateur;
            //int b = denominateur;
            //if (a < 0) a = -a;
            //if (b < 0) b = -b;

            int D = 0;

            if (numerateur < 0)
            {
                numerateur = -numerateur;
            }

            if (denominateur < 0)
            {
                denominateur = -denominateur;
            }

           

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
            int pgcd = this.GetPgcd();
            numerateur = numerateur / pgcd;
            denominateur = denominateur / pgcd;
        }

    }
}
