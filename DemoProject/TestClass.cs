//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DemoProject
{
    class MathOp
    {
        public void Addition (int a, int b)
        {
            Console.WriteLine("Addition: "+ (a + b));
        }
        public void Substraction(double a, double b)
        {
            Console.WriteLine("Substraction: " + (a - b));
        }
        public void Multiplication(double a, double b)
        {
            Console.WriteLine("Multiplication: " + (a * b));
        }
        public void Division(double a, double b)
        {
            Console.WriteLine("Division: " + (a / b));
        }
        public void Mod(double a, double b)
        {
            Console.WriteLine("Mod: " + (a % b));
        }
    }
    class TestClass
    {
        public static void Main(string[] args)
        {
            MathOp o = new MathOp();
            o.Addition(10, 5);
            o.Substraction(10, 5);
            o.Multiplication(10, 5);
            o.Division(10, 5);
            o.Mod(10, 5);
        }
    }
}
