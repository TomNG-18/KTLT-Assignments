using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Fraction
    {
        public int numerator;
        public int denominator;

        public Fraction()
        {

        }

        public Fraction(int a, int b)
        {
            this.numerator = a;
            this.denominator = b;
        }

        public Fraction(int a)
        {
            this.numerator = a;
            this.denominator = 1;
        }
        public void Input()
        {
            string[] input = new string[2];
            input = Console.ReadLine().Split(' ');
            numerator = Convert.ToInt32(input[0]);
            denominator = Convert.ToInt32(input[1]);
            Console.WriteLine("--> {0}", ToString());
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

        private static int UCLN(int a, int b)
        {
            int r = a % b;
            if (r == 0)
                return b;

            return UCLN(b, r);
        }
        public void Simplify()
        {
            while (UCLN(numerator, denominator) != 1)
            {
                int temp = numerator;
                numerator /= temp;
                denominator /= temp;
            }
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
