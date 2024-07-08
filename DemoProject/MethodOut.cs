using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class abc
    {
        public void sum(int a, int b, out int c)
        {
            c = a + b;
        }
    }

    internal class MethodOut
    {
        static void Main()
        {
            int a;
            abc l = new abc();
            l.sum(20, 25,out a);
            Console.WriteLine(a);
        }
        
    }
}
