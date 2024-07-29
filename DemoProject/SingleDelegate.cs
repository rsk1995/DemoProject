using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public delegate void DisplayDelegate();
    class add
    {
        public void Display()
        {
            Console.WriteLine("Display method from add class");
        }
    }
    class mul
    {
        public void Display()
        {
            Console.WriteLine("Display method from mul class");
        }
    }
    class div
    {
        public void Display()
        {
            Console.WriteLine("Display method from div class");
        }
    }
    internal class SingleDelegate
    {
        static void Main()
        {
            add a = new add();
            mul m = new mul();
            div d = new div();
            DisplayDelegate dis = new DisplayDelegate(a.Display);
            dis();
            //dis = new DisplayDelegate(m.Display);
            dis = m.Display;
            dis();
            //dis = new DisplayDelegate(d.Display);
            dis = m.Display;
            dis();
            Console.WriteLine("\nAll methods called in single delegate!");
            DisplayDelegate dp = a.Display;
            dp += m.Display;
            dp += d.Display;
            dp();
        }
    }
}