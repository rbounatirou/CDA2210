using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    internal class Fraction 
    {
        private int denominateur;
        private int numerateur;
        

        public Fraction(int numerateur, int denominateur)
        {
            if (denominateur == 0)
                throw new Exception("Impossible de créer une instance ayant un dénominateur à 0");
            this.denominateur = denominateur;
            this.numerateur = numerateur;
        }

        public Fraction(int numerateur) : this(numerateur, 1) { }

        public Fraction() : this(0, 1) { }

        public static bool operator==(Fraction f1, Fraction f2)
        {
            return (f1.numerateur*f2.denominateur) == (f2.numerateur*f1.denominateur);
        }

        public static bool operator!=(Fraction f1, Fraction f2)
        {
            return (f1.numerateur * f2.denominateur) != (f2.numerateur * f1.denominateur);
        }

        public static Fraction operator-(Fraction f1, Fraction f2)
        {
            return f1 + new Fraction(-f2.numerateur, f2.denominateur);
        }

        public static Fraction operator+(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1.numerateur * f2.denominateur + f2.numerateur * f1.denominateur,
                f1.denominateur * f2.denominateur);
            f.Reduire();
            return f;
        }

        public static Fraction operator/(Fraction f1, Fraction f2)
        {
            return f1 * new Fraction(f2.denominateur, f2.numerateur);
        }

        public static Fraction operator*(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1.numerateur * f2.numerateur, 
                f1.denominateur * f2.denominateur);
            f.Reduire();
            return f;
        }

        public static bool operator>(Fraction f1, Fraction f2)
        {
            return (f1.numerateur * f2.denominateur) > (f2.numerateur * f1.denominateur);
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return (f1.numerateur * f2.denominateur) < (f2.numerateur * f1.denominateur);
        }

        public static bool operator >=(Fraction f1, Fraction f2)
        {
            return (f1.numerateur * f2.denominateur) >= (f2.numerateur * f1.denominateur);
        }

        public static bool operator <=(Fraction f1, Fraction f2)
        {
            return (f1.numerateur * f2.denominateur) <= (f2.numerateur * f1.denominateur);
        }

        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }


        private void Inverse()
        {
            if (numerateur == 0)
                throw new Exception("Impossible d'inverser le numerateur et le denominateur d'une fraction avec un numerateur à 0");
            int numTmp = numerateur;
            numerateur = denominateur;
            denominateur = numerateur;
        }

        private void Oppose()
        {

            numerateur = -numerateur;
        }

        private void Reduire()
        {
            
            if (numerateur != 0)
            {
                if (numerateur < 0 && denominateur < 0)
                {
                    numerateur -= numerateur;
                    denominateur -= denominateur;
                }
                int pgcd = GetPgcd();
                if (pgcd != 1)
                {

                    numerateur /= pgcd;
                    denominateur /= pgcd;
                }                
            } else
            {
                denominateur = 1;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", numerateur, denominateur);
        }

    }
}
