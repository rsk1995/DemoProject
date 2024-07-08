using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class PrePostIncrement
    {
        static void Main()
        {
            int a = 10;
            int b = a++;
            Console.WriteLine(b);
            int c = ++a;
            Console.WriteLine(c);
        }
    }
}
