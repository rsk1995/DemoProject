using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class ArrayAscending
    {
        static void Main()
        {
            int[] a = {22,45,98,3,111};
            Console.WriteLine("Original array is:");
            foreach (int b in a)
            {
                Console.Write(b + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (a[j] > a[i])
                    {
                        int temp = 0;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nAscending array is: ");
            foreach (int b in a)
            {
                Console.Write(b + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (a[j] < a[i])
                    {
                        int temp = 0;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nDescending array is: ");
            foreach (int b in a)
            {
                Console.Write(b + "  ");
            }
            Console.WriteLine();
        }
    }
}
