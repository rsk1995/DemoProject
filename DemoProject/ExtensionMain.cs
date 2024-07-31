using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ExtensionMain
    {
        static void Main()
        {
            double a, b, c;
            Console.WriteLine("Enter three numbers for arithmatic operations!");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            ExtensionBase eb = new ExtensionBase();
            eb.ExtAdd(a,b,c);
            eb.ExtSub();
            eb.ExtMul();
            eb.ExtDiv();
            eb.ExtMod();
        }
    }
}
