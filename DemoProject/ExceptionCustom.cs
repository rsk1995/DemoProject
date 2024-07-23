using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class NegativeNumberException : Exception
    {
        int a;
        //public NegativeNumberException()
        //{
        //    Console.Write("Enter positive number: ");
        //    a = Convert.ToInt32(Console.ReadLine());
        //}
        public void DisplayNumber()
        {
            Console.Write("Enter positive number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                throw new Exception("0 is neither negative nor positive...!");
            }
            else if (a < 0)
            {
                throw new Exception("Entered number is negative number...!");
            }
            //Console.WriteLine("Entered number is positive...!");
            //Console.WriteLine();
        }
    }

    class ExceptionCustom
    {
        static void Main()
        {
            NegativeNumberException NE = new NegativeNumberException();
            try
            {
                NE.DisplayNumber();
                Console.WriteLine("Entered number is positive...!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}