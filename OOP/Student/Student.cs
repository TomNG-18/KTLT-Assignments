using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_oop
{
    class Student
    {
        private string studentid;
        private string name;
        private int birthYear;
        private bool gender;
        private string stdClass;

        public Student()
        {

        }

        public Student(string a, string b, int c, bool d, string e)
        {
            DateTime now = new DateTime();

            this.studentid = a;
            this.name = b;
            if (birthYear >= 1900 && birthYear <= now.Year)
            {
                this.birthYear = c;
            }
            else
                Console.Write("Nam sinh khong hop le");

            this.gender = d;
            this.stdClass = e;
        }

        public string GetStudentID()
        {
            return studentid;
        }

        public void SetStudentID(string newid)
        {
            studentid = newid;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string newName)
        {
            name = newName;
        }
        public void SetBirthYear(int newBirthYear)
        {
            DateTime now = new DateTime();
            if (newBirthYear >= 1900 && newBirthYear <= now.Year)
            {
                newBirthYear = 1900;
            }
            birthYear = newBirthYear;
        }
        public int GetBirthYear()
        {
            return birthYear;
        }
        public bool GetGender()
        {
            return gender;
        }

        public string GetStdClass()
        {
            return stdClass;
        }

        public void SetStdClass(string newStdClass)
        {
            stdClass = newStdClass;
        }

        public void Input()
        {
            studentid = Console.ReadLine();
            name = Console.ReadLine();
            birthYear = Convert.ToInt32(Console.ReadLine());
            gender = Convert.ToBoolean(Console.ReadLine());
            stdClass = Console.ReadLine();
        }

        public int GetAge()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthYear;
            return age;
        }

        public void PrintInfo()
        {
            Console.WriteLine(studentid);
            Console.WriteLine(name);
            Console.WriteLine(birthYear);
            if (gender == true)
                Console.WriteLine("Nam");
            else
                Console.WriteLine("Nu");
            Console.WriteLine(stdClass);
        }
    }
}
