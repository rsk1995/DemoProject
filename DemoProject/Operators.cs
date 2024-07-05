using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class ArithmaticOperators
    {
        public ArithmaticOperators(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("***ARITHMATIC OPERATOS***");
            Console.WriteLine("Addition of 20 & 10 is: "+ (FirstNumber+SecondNumber));
            Console.WriteLine("Substraction of 20 & 10 is: " + (FirstNumber - SecondNumber));
            Console.WriteLine("Multiplication of 20 & 10 is: " + (FirstNumber * SecondNumber));
            Console.WriteLine("Divition of 20 & 10 is: " + (FirstNumber / SecondNumber));
            Console.WriteLine("Modulus of 20 & 10 is: " + (FirstNumber % SecondNumber));
            Console.WriteLine();
        }
    }
    class RelationalOperators
    {
        bool a;
        public RelationalOperators(int FirstNumber, int SecondNUmber)
        {
            Console.WriteLine("***RELATIONAL OPERATOS***");
            a = (FirstNumber==SecondNUmber);
            Console.WriteLine("20 & 10 are equals?: " + a);
            a = (FirstNumber != SecondNUmber);
            Console.WriteLine("20 & 10 are not equal?: " + a);
            a = (FirstNumber > SecondNUmber);
            Console.WriteLine("20 is greater than 10?: " + a);
            a = (FirstNumber < SecondNUmber);
            Console.WriteLine("20 is less than 10?: " + a);
            a = (FirstNumber >= SecondNUmber);
            Console.WriteLine("20 is greater than or equal to 10?: " + a);
            a = (FirstNumber <= SecondNUmber);
            Console.WriteLine("20 is less than or equal to 10?: " + a);
            Console.WriteLine();
        }
    }
    class LogicalOperators
    {
        public LogicalOperators(int Number)
        {
            bool a;
            Console.WriteLine("***LOGICAL OPERATIORS***");
            a = (Number < 30 && Number > 15);
            Console.WriteLine("20 is less than 30? and 20 is greater than 15? : " + a);
            a = (Number < 30 && Number > 25);
            Console.WriteLine("20 is less than 30? and 20 is greater than 25? : " + a);
            a = (Number < 30 || Number > 25);
            Console.WriteLine("20 is less than 30? or 20 is greater than 25? : " + a);
            a = (Number < 15 || Number > 25);
            Console.WriteLine("20 is less than 15? or 20 is greater than 25? : " + a);
            a = (!(Number < 15 || Number > 25));
            Console.WriteLine("Invert of (20 is less than 15? or 20 is greater than 25?) : " + a);
            Console.WriteLine();
        }
    }
    class Operators
    {
        static void Main()
        {
            ArithmaticOperators AO =new ArithmaticOperators(20, 10);
            RelationalOperators RO = new RelationalOperators(20, 10);
            LogicalOperators LO = new LogicalOperators(20);
        }
    }
}
