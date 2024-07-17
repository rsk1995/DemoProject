using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    abstract class Shape
    {
        public abstract double CalculateArea();
        public virtual void Display()
        {
            Console.WriteLine("Shapes are RECTANGLE, CIRCLE & TRANGLE...!\n");
        }
    }
    class NewRectangle : Shape
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Its Rectangle!");
            Console.WriteLine("Length: 5.8 & Width: 4.3");
        }
        public override double CalculateArea()
        {
            double length = 5.8, width = 4.3;
            double ar = length * width;
            return ar;
        }
    }
    class NewCircle : Shape
    {
        public override void Display()
        {
            Console.WriteLine("Its Circle!");
            Console.WriteLine("Radius: 7.7");
        }
        public override double CalculateArea()
        {
            double radius = 7.7;
            double ar = 3.14 * (radius * radius);
            return ar;
        }
    }
    class NewTriangle : Shape
    {
        public override void Display()
        {
            Console.WriteLine("Its Triangle!");
            Console.WriteLine("Base=5.5 & Height=3.5");
        }
        public override double CalculateArea()
        {
            double length = 5.5, width = 3.5;
            double ar = (length * width) / 2;
            return ar;
        }
    }
    class AbstractClassMethods
    {
        static void Main()
        {
            NewRectangle NR = new NewRectangle();
            NR.Display();
            Console.WriteLine("Area of Rectangle is: " + NR.CalculateArea());
            Console.WriteLine();
            NewCircle NC = new NewCircle();
            NC.Display();
            Console.WriteLine("Area of Circle is: " + NC.CalculateArea());
            Console.WriteLine();
            NewTriangle ND = new NewTriangle();
            ND.Display();
            Console.WriteLine("Area of Triangle is: " + ND.CalculateArea());
            Console.WriteLine();
        }
    }
}