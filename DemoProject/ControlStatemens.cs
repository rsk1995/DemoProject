using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class ControlStatemens
    {
        static void Main()
        {
            double UserValue;
            Console.Write("Enter any number to verify its positive or negative: ");
            UserValue = Convert.ToDouble(Console.ReadLine());
            if (UserValue > 0)
            {
                Console.WriteLine("You entered positive number!");
            }
            else if (UserValue < 0)
            {
                Console.WriteLine("\nYou entered negative number!");
            }
            else
            {
                Console.WriteLine("You entered zero!");
            }
            double SMarks;
            Console.Write("\n\nEnter student percentage: ");
            SMarks = Convert.ToDouble(Console.ReadLine());
            if (SMarks < 0)
            {
                Console.WriteLine("Please enter valid percentage between 0 to 100!");
            }
            else if (SMarks >= 75)
            {
                Console.WriteLine("\nCongratulations!!!\nStudent PASSED! Grade: A");
            }
            else if (SMarks >= 60 && SMarks < 75)
            {
                Console.WriteLine("\nCongratulations!!!\nStudent PASSED! Grade: B");
            }
            else if (SMarks >= 45 && SMarks < 60)
            {
                Console.WriteLine("\nWell Done!!!\nStudent PASSED! Grade: C");
            }
            else if (SMarks >= 35 && SMarks < 45)
            {
                Console.WriteLine("\nStudent PASSED! Grade: D");
            }
            else
            {
                Console.WriteLine("\nAll the best!!!\nStudent FAILED! Grade: F");
            }
            Console.WriteLine("\nGrade A: PASSED (>75)\nGrade B: PASSED (>60 to <75)\nGrade C: PASSED (>45 to <60)\nGrade D: PASSED (>35 to <45)\nGrade F: FAILED (<35");
        }
    }
}