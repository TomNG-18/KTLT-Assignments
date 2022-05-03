using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Person
    {
        public string name;
        public int birthYear;
        public string address;

        public Person() { }

        public Person(string name, int birthYear, string address)
        {
            DateTime date = DateTime.Today;
            this.name = name;
            
            if (birthYear <= 1900 && birthYear >= date.Year)
                Console.WriteLine("Nam sinh khong hop le!");
            else
                this.birthYear = birthYear;
            
            this.address = address;
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Birth Year:");
            birthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Address:");
            address = Console.ReadLine();
        }

        public int GetAge()
        {
            DateTime date = DateTime.Today;
            return date.Year - birthYear;
        }

        public virtual string ToString()
        {
            return $"Person[Name: {name}, Age: {GetAge()}, Address: {address}]";
        }
    }
}
