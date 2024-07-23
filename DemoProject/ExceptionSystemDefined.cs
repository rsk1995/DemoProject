using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class AdditionException
    {
        public void AddExp()
        {
            int a = Int32.MaxValue;
            int b = checked(a + 3);
        }
        public void SubExp()
        {
            int a = Int32.MinValue;
            int b = checked(a - 3);
        }
        public void MulExp()
        {
            int a = int.Parse("Ramesh");
        }
        public void DivExp()
        {
            int b = 25,c = 0;
            int a = b / c;
            Console.WriteLine("Division is: "+a);
        }
    }

    class ExceptionSystemDefined
    {
        static void Main()
        {
            Console.WriteLine("Max Size of Integer: " + Int32.MaxValue);
            AdditionException AE = new AdditionException();
            try
            {
                AE.AddExp();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Artithmatic Over Flow Exception Caught!");
            }
            Console.WriteLine("Min Size of Integer: " + Int32.MinValue);
            try
            {
                AE.SubExp();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Artithmatic Over Under Flow Exception Caught!");
                Console.WriteLine();
            }
            try
            {
                AE.MulExp();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception Caught!");
            }
            try
            {
                AE.DivExp();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide By Zero Exception Caught!");
            }
        }
    }
}