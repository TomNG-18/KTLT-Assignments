using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class MixedFraction:Fraction
    {
        public MixedFraction(int wholePart, int numerator, int denominator)
        {
            this.numerator = wholePart * denominator + numerator;
            this.denominator = denominator;
        }
        public MixedFraction(Fraction f)
        {
            
        }
    }
}
