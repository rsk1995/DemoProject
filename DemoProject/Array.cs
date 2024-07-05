using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Array
    {
        static void Main()
        {
            int[] array = {5,10,15,20,23};
            int sum = 0;
            double avg = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            avg = (double) sum / array.Length;
            Console.WriteLine("The used array elements are: 5,10,15,20,23\n");
            Console.WriteLine("Addtion Of an array element is: " + sum);
            Console.WriteLine("Average Of an array element is: " + avg);

            //string[] str = { "1", "ramesh", "pqr", "10.25", "g" };
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]); ;
            //}
        }
    }
}
