using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    abstract class Shape1
    {
        public abstract void DisplayDetails();
    }
    class Circle1 : Shape1
    {
        public override void DisplayDetails()
        {
            Console.WriteLine("Shape: Circle");
            Console.WriteLine("Color: Red");
            Console.WriteLine();
        }
    }
    class Rectangle1 : Shape1
    {
        public override void DisplayDetails()
        {
            Console.WriteLine("Shape: Rectangle");
            Console.WriteLine("Color: Yellow");
            Console.WriteLine();
        }
    }

    internal class HierarchicalInheritance
    {
        static void Main()
        {
            Console.WriteLine("Hierarchical Inheritance...!");
            Console.WriteLine();
            Shape1 a = new Circle1();
            a.DisplayDetails();
            Shape1 b = new Rectangle1();
            b.DisplayDetails();
        }
    }
}
