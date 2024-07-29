using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DemoProject
{
    public delegate void MathOps(double a, double b);
    class MathOperation
    {
        public void Addition(double a, double b)
        {
            Console.WriteLine("Addition of two numbers: " + (a+b));
        }
        public void Substraction(double a, double b)
        {
            Console.WriteLine("Substraction of two numbers: " + (a - b));
        }
        public void Multiplication(double a, double b)
        {
            Console.WriteLine("Multiplication of two numbers: " + (a * b));
        }
        public void Division(double a, double b)
        {
            Console.WriteLine("Division of two numbers: " + (a / b));
        }
        public void Mod(double a, double b)
        {
            Console.WriteLine("Mod of two numbers: " + (a % b));
        }
    }

    internal class MultiCastDelegate
    {
        static void Main()
        {
            Console.WriteLine("Mathematic Opertations using multi cast delegate!\n");
            MathOperation mp = new MathOperation();
            MathOps mps = new MathOps(mp.Addition);
            mps += mp.Substraction;
            mps += mp.Multiplication;
            mps += mp.Division;
            mps += mp.Mod;
            mps(23.45, 41.12);
        }
    }
}
