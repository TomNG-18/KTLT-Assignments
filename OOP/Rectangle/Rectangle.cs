using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Rectangle
{
    class Rectangle
    {
        private double width;
        private double height;

        public Rectangle()
        {

        }

        public Rectangle(double a, double b)
        {
            this.width = a;
            this.height = b;
        }

        public void Input()
        {
            Console.WriteLine("Nhap chieu dai, chieu rong:");
            string[] numList = Console.ReadLine().Split(' ');
            width = Convert.ToDouble(numList[0]);
            height = Convert.ToDouble(numList[1]);
        }

        public override string ToString()
        {
            return $"width = {width} ; height = {height}";
        }

        public double GetPerimeter()
        {
            double perimeter = (width + height) * 2;
            return perimeter;
        }

        public double GetArea()
        {
            double area = width * height;
            return area;
        }

        public bool IsSameArea(Rectangle rect)
        {
            if (GetArea() == rect.GetArea())
                return true;
            else
                return false;
        }
    }
}
