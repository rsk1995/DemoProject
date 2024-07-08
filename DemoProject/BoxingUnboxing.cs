using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class BoxingUnboxing
    {
        static void Main()
        {
            int x = 5;
            int y = 3;
            int w;
            Object o;
            o = x;
            o = 10;
            w=y* (int)o;
            //w = y;
            //w = (int)o;
            Console.WriteLine(w);
            Console.WriteLine(x);
            Console.WriteLine(o);
        }
    }
}
