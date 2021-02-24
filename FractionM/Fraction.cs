using System;

namespace Fraction
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator != 0)
            {
                this.denominator = denominator;
                this.numerator = numerator;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Denominator can't be zero");
            }
        }

        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        public Fraction(in Fraction fraction)
        {
            this.numerator = fraction.numerator;
            this.denominator = fraction.denominator;
        }

        public int Numerator => numerator;
        public int Denominator => denominator;
        public static implicit operator Fraction(int numerator) => new Fraction(numerator);  
        
        public static Fraction Reduce(Fraction fraction1)
        {
            int factor = fraction1.Gcf(fraction1);
            return new Fraction(fraction1.numerator / factor, fraction1.denominator / factor);
        }

        
        public int Gcf(Fraction fraction1)
        {
            int i;
            if (fraction1.numerator <= fraction1.denominator)
            {
                i = Math.Abs(fraction1.numerator);
            }
            else
            {
                i = Math.Abs(fraction1.denominator);
            }

            while (i > 0)
            {
                if (fraction1.numerator % i == 0 && fraction1.denominator % i == 0)
                {
                    return i;
                }
                else
                {
                    i--;
                }
            }

            return i;
        }

        public static int Lcm(Fraction fraction1, Fraction fraction2)
        {
            int lcm;
            if (fraction1.Denominator >= fraction2.Denominator)
            {
                lcm = fraction1.Denominator;
            }
            else
            {
                lcm = fraction2.Denominator;
            }
            while (lcm%fraction1.Denominator!=0 || lcm%fraction2.Denominator!=0 )
            {
                lcm++;
            }
            return lcm;
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            int lcd = Fraction.Lcm(fraction1, fraction2);
            int f1Num = fraction1.numerator * (lcd/fraction1.denominator);
            int f2Num = fraction2.numerator * (lcd/fraction2.denominator);
            Fraction answer = new Fraction(f1Num + f2Num, lcd);
            return answer;
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            int lcd = Fraction.Lcm(fraction1, fraction2);
            int f1Num = fraction1.numerator * (lcd / fraction1.denominator);
            int f2Num = fraction2.numerator * (lcd / fraction2.denominator);
            Fraction answer = new Fraction(f1Num - f2Num, lcd);
            return answer;
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            Fraction answer = new Fraction(fraction1.numerator * fraction2.numerator, fraction1.denominator * fraction2.denominator);
            return answer;
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            Fraction answer = new Fraction(fraction1.numerator * fraction2.denominator, fraction1.denominator * fraction2.numerator);
            return answer;
        }

        public static Double operator +(Fraction fraction1, double numerator)
        {
            return (double)fraction1 + numerator;
        }

        public static Double operator -(Fraction fraction1, double numerator)
        {
            return (double)fraction1 - numerator;
        }

        public static Double operator *(Fraction fraction1, double numerator)
        {
            return (double)fraction1 * numerator;
        }

        public static Double operator /(Fraction fraction1, double numerator)
        {
            return (double)fraction1 / numerator;
        }
        public static Double operator +(double numerator, Fraction fraction1)
        {
            return numerator + (double)fraction1;
        }
        public static Double operator -(double numerator, Fraction fraction1)
        {
            return numerator - (double)fraction1;
        }
        public static Double operator *(double numerator, Fraction fraction1)
        {
            return numerator * (double)fraction1;
        }
        public static Double operator /(double numerator, Fraction fraction1)
        {
            return numerator / (double)fraction1;
        }
        public static Fraction operator -(Fraction fraction1)
        {
            Fraction negation = new Fraction(-fraction1.numerator, fraction1.denominator);
            if (negation.numerator < 0 && negation.denominator < 0)
            {
                negation = new Fraction(-negation.numerator, -negation.denominator);
            }
            return negation;
        }

        public static bool operator <(Fraction fraction1, Fraction fraction2)
        {
            int lcd = Fraction.Lcm(fraction1, fraction2);
            int f1Num = fraction1.numerator * (lcd / fraction1.denominator);
            int f2Num = fraction2.numerator * (lcd / fraction2.denominator);
            return f1Num < f2Num;
        }

        public static bool operator >(Fraction fraction1, Fraction fraction2)
        {
            int lcd = Fraction.Lcm(fraction1, fraction2);
            int f1Num = fraction1.numerator * (lcd / fraction1.denominator);
            int f2Num = fraction2.numerator * (lcd / fraction2.denominator);
            return f1Num > f2Num;
        }
        public static bool operator >=(Fraction fraction1, Fraction fraction2)
        {
            int lcd = Fraction.Lcm(fraction1, fraction2);
            int f1Num = fraction1.numerator * (lcd / fraction1.denominator);
            int f2Num = fraction2.numerator * (lcd / fraction2.denominator);
            return f1Num >= f2Num;
        }
        public static bool operator <=(Fraction fraction1, Fraction fraction2)
        {
            int lcd = Fraction.Lcm(fraction1, fraction2);
            int f1Num = fraction1.numerator * (lcd / fraction1.denominator);
            int f2Num = fraction2.numerator * (lcd / fraction2.denominator);
            return f1Num <= f2Num;
        }

        public static bool operator ==(Fraction fraction1, Fraction fraction2)
        {
            int lcd = Fraction.Lcm(fraction1, fraction2);
            int f1Num = fraction1.numerator * (lcd / fraction1.denominator);
            int f2Num = fraction2.numerator * (lcd / fraction2.denominator);
            return f1Num == f2Num;
        }

        public static bool operator !=(Fraction fraction1, Fraction fraction2)
        {
            return !(fraction1 == fraction2);
        }

        public static explicit operator double(Fraction fraction)
        {
            return (double)fraction.Numerator / fraction.Denominator;
        }

        public static explicit operator int(Fraction fraction)
        {
            return fraction.Numerator / fraction.Denominator;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else {
                Fraction fraction = (Fraction) obj;
                return (numerator == fraction.denominator) && (denominator == fraction.denominator);
            }
        }
    }
}