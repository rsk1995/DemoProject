using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Animal
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape!");
        }
        public virtual void Area()
        {

        }
    }
    class Circle : Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle!");
        }
        public override void Area()
        {
            double radius = 6.5;
            double ar = 3.14 * radius * radius;
            Console.WriteLine("Area of circle: " + ar);
        }
    }
    class Rectangle : Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle!");
        }
        public override void Area()
        {
            double length = 5.5, width=3.5;
            double ar = length * width;
            Console.WriteLine("Area of Rectangle: " + ar);
        }
    }
    class Trangle : Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a trangle!");
        }
        public override void Area()
        {
            double length = 5.5, width = 3.5;
            double ar = (length * width) / 2;
            Console.WriteLine("Area of Triangle: " + ar);
        }
    }

    class DynamicPolymorphism
    {
        static void Main()
        {
            Animal anm1 = new Animal();
            anm1.Draw();
            Animal anm2 = new Circle();
            anm2.Draw();
            anm2.Area();
            Animal anm3 = new Rectangle();
            anm3.Draw();
            anm3.Area();
            Animal anm4 = new Trangle();
            anm4.Draw();
            anm4.Area();
        }
    }
}
