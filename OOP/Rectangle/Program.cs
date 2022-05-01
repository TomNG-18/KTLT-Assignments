using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle();

            //Input
            rect1.Input();
            rect2.Input();
            
            //ToString
            Console.WriteLine("HCN1: {0}", rect1.ToString());
            Console.WriteLine("HCN2: {0}", rect2.ToString());

            //Perimeter
            double per1 = rect1.GetPerimeter();
            double per2 = rect2.GetPerimeter();

            Console.WriteLine("Chu vi HCN 1 = {0}", per1);
            Console.WriteLine("Chu vi HCN 2 = {0}", per2);

            //Area
            double area1 = rect1.GetArea();
            double area2 = rect2.GetArea();

            Console.WriteLine("Dien tich HCN 1 = {0}", area1);
            Console.WriteLine("Dien tich HCN 2 = {0}", area2);

            //IsSameArea
            bool isSameArea = rect1.IsSameArea(rect2);
            if (isSameArea)
                Console.WriteLine("2 HCN co dien tich bang nhau");
            else
                Console.WriteLine("2 HCN co dien tich khong bang nhau");

            Console.ReadLine();
        }
    }
}
