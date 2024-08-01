using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class RefExample
    {
        static void Main()
        {
            int a = 10;
            IncrementValue(ref a);
            Console.WriteLine("Value passed as 10 & incremented value is: " + a);
        }
        static void IncrementValue(ref int b)
        {
            b++;
        }
    }
}
