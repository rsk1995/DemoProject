using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public delegate void AddDel(double a, double b);
    public delegate void SubDel(double a, double b);
    class Math
    {
        public void add(double a, double b)
        {
            Console.WriteLine("Addition of two numbers: "+(a+b));
        }
        public void sub(double a, double b)
        {
            Console.WriteLine("Substraction of two numbers: " + (a + b));
        }
    }

    internal class UniCastDelegate
    {
        static void Main()
        {
            Console.WriteLine("Addition & substraction of two number using delegate!\n");
            Math m = new Math();
            AddDel ad = new AddDel(m.add);
            SubDel sd = new SubDel(m.sub);
            ad(20.35, 36.04);
            sd(3.14, 2.4);
        }
    }
}