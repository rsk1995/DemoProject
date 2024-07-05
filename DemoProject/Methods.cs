using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class DemoMethods
    {
        public void Greet(string a)
        {
            Console.WriteLine(a);
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        public void PrintMessage(string message, int b)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(message);
            }
        }
    }

    class Methods
    {
        static void Main()
        {
            DemoMethods DM = new DemoMethods();
            DM.Greet("Hello Team!\n\nGood Morning...!\n ");
            Console.WriteLine("Addition of #2 digits(10 & 10) is: " + DM.Add(10, 10));
            Console.WriteLine();
            Console.WriteLine("Multiplication of #2 digits(10 & 10) is: " + DM.Multiply(10, 10));
            Console.WriteLine();
            Console.WriteLine("Multiplication of #3 digits (10, 10 & 10) is: " + DM.Multiply(10, 10, 10));
            Console.WriteLine();
            DM.PrintMessage("Heaven is under our feet as well as over our heads!", 3);
        }
    }
}
