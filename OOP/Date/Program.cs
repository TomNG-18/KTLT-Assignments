using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();

            date.setDate(2,3,2003);
            Console.WriteLine(date.ToString());
            Console.ReadLine();
        }
    }
}
