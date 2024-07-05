using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class EnumAssignment
    {
        enum Year
        {
            January, 
            February, 
            March, 
            April, 
            May, 
            June, 
            July, 
            August, 
            September, 
            October, 
            November, 
            December,
        }

        static void Main()
        {
            Console.Write("Enter Month: ");
            //int month = Convert.ToInt32(Console.ReadLine());
            string month = Console.ReadLine();
            Console.WriteLine();
            Year YR = (Year)Enum.Parse(typeof(Year), month);
            switch (YR)
            {
                case Year.January:
                    Console.WriteLine("Starting month of year!");
                    break;
                case Year.February:
                    Console.WriteLine("February is the 2nd or second month of the year!");
                    break;
                case Year.March:
                    Console.WriteLine("March is the 3rd or third month of the year!");
                    break;
                case Year.April:
                    Console.WriteLine("April is the 4th or fourth month of the year!");
                    break;
                case Year.May:
                    Console.WriteLine("May is the 5th or fifth month of the year!");
                    break;
                case Year.June:
                    Console.WriteLine("June is the 6th or sixth month of the year!");
                    break;
                case Year.July:
                    Console.WriteLine("July is the 7th or seventh month of the year!");
                    break;
                case Year.August:
                    Console.WriteLine("August is the 8th or eighth month of the year!");
                    break;
                case Year.September:
                    Console.WriteLine("September is the 9th or ninth month of the year!");
                    break;
                case Year.October:
                    Console.WriteLine("October is the 10th or tenth month of the year!");
                    break;
                case Year.November:
                    Console.WriteLine("November is the 11th or eleventh month of the year!");
                    break;
                case Year.December:
                    Console.WriteLine("Ending month of year!");
                    break;
                default:
                    Console.WriteLine("You entered invalid month!");
                    break;
            }
        }
    }
}