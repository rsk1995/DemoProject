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
            Console.Write("Enter any numner: ");
            int a = Convert.ToInt32(Console.ReadLine()); ;
            IncrementValue(ref a);
            Console.WriteLine("Incremented value is: " + a);
        }
        static void IncrementValue(ref int b)
        {
            b++;
        }
    }
}
