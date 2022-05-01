using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<Student> students = new List<Student>();
            Student student;
            student = new Student();
            for (int i = 0; i < n; i++)
            {               
                students.Add(student);
                student.Input();
            }

            for(int i = 0; i < n; i++)
            {
                student.PrintInfo();
            }
            Console.ReadLine();
        }
    }
}
