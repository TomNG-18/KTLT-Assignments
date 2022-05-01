using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            f1.Input();
            
            Fraction f2 = new Fraction();
            f2.Input();

            Fraction add = f1.Add(f2);
            Fraction subtract = f1.Subtract(f2);
            
            Console.WriteLine(add);
            Console.WriteLine(subtract);
            Console.ReadLine();
        }
    }
}
