﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();

            st.Input();

            Console.WriteLine(st.ToString());
            Console.ReadLine();
        }
    }
}
