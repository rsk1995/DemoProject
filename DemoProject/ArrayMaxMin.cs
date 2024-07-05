using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ArrayMaxMin
    {
        static void Main()
        {
            int[] arr = { 50, 30, 80, 10, 40 };
            int max = arr[0], min = arr[0];
            Console.Write("Array: ");
            foreach (int a in arr)
            {
                Console.Write("\t"+a);
            }
            Console.WriteLine();
            for (int i = 1; i < arr.Length; i++)
            {
               if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Maximum value in array: "+max);
            Console.WriteLine();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Minimum value in array: " + min);
            Console.WriteLine();
        }
    }
}
