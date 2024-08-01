using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class OutExample
    {
        static void Main()
        {
            InitializeValues(out int x, out string y);
            Console.WriteLine("Entered value is: " + x);
            Console.WriteLine("Entered string is: " + y);
        }
        static void InitializeValues(out int a, out string b)
        {
            Console.Write("Enter any value: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter any string: ");
            b = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
