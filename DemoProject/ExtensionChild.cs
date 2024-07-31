using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    static class ExtensionChild
    {
        public static void ExtSub(this ExtensionBase o)
        {
            Console.WriteLine("Substraction of three numbers: " + (o.a-o.b-o.c));
        }
        public static void ExtMul(this ExtensionBase o)
        {
            Console.WriteLine("Multiplication of three numbers: " + (o.a * o.b * o.c));
        }
        public static void ExtDiv(this ExtensionBase o)
        {
            Console.WriteLine("Division of first & second numbers: " + (o.a / o.b));
        }
        public static void ExtMod(this ExtensionBase o)
        {
            Console.WriteLine("Reminder of first & second numbers: " + (o.a % o.b));
        }
    }
}