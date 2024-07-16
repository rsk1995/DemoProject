using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Calculator
    {
        const double pi= 3.14;
        public void Area(double radius)
        {
            double ar = pi * radius * radius;
            Console.WriteLine("Area of circle: "+ar);
        }
        public void Area(double length, double width)
        {
            double ar = length * width;
            Console.WriteLine("Area of Rectangle: "+ar);
            ar = (length * width)/2;
            Console.WriteLine("Area of Triangle: " + ar);
        }
    }

    class StaticPolymorphism
    {
        static void Main()
        {
            Calculator cal = new Calculator();
            cal.Area(7.5);
            cal.Area(5.4, 6.8);
        }
    }
}
