using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Fraction
    {
        public int numerator;
        public int denominator;

        public Fraction() { }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        public void GCD(int a, int b)
        {
            int r = a % b;
            int tmp;
            while(r != 0)
            {
                tmp = r;
                a = b;
                b = tmp;
            }
        }

        public void Simplify()
        {
            GCD(numerator, denominator);
            while(denominator != 1)
            {
                int temp = numerator;
                numerator = denominator;
                numerator = temp;
            }
            Simplify();
        }

        public Fraction Add(Fraction p)
        {
            Fraction result = new Fraction((numerator * p.denominator + p.numerator * denominator), (p.denominator * denominator));
            result.Simplify();
            return result;
        }

        public Fraction Subtract(Fraction p)
        {
            Fraction result = new Fraction((numerator * p.denominator - p.numerator * denominator), (p.denominator * denominator));
            result.Simplify();
            return result;
        }

        public Fraction Multiply(Fraction p)
        {
            Fraction result = new Fraction(numerator * p.numerator, denominator * p.denominator);
            result.Simplify();
            return result;
        }

        public Fraction Divide(Fraction p)
        {
            Fraction result = new Fraction(numerator * p.denominator, denominator * p.numerator);
            result.Simplify();
            return result;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public double Decimal()
        {
            return (double)numerator / denominator;
        }
    }
}
