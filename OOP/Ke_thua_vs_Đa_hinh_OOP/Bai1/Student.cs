using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Student : Person
    {
        private string program;
        private int year;

        public Student() { }
        public Student(string name, int birthYear, string address, string program, int year)
        {
            this.program = program;
            this.year = year;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter Program:");
            program = Console.ReadLine();

            Console.WriteLine("Enter year:");
            year = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString() +  $"-Program: {program}, Year: {year}";
        }

    }
}
