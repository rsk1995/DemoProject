using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class ArrayOps
    {
        int[] arr = new int[5];
        public ArrayOps()
        {
            Console.WriteLine("Enter any 5 numbers!\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter {0} array element: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nAbove Array prepared using constructor concept (Default Constructor)!!!\n");
        }
        public ArrayOps(ArrayOps AO)
        {
            int min = AO.arr[0], max = AO.arr[0];
            Console.WriteLine("Below Array Operations using Copying Construstor!\n\nOriginal Array:");
            foreach (int a in AO.arr)
            {
                Console.Write(a + "\t");
            }
            Console.WriteLine("\n\nNumber of array elements: " + AO.arr.Length);
            Console.WriteLine("\nPrinting alternate elements in array!");
            for (int i = 0; i < 5; i+=2)
            {
                Console.Write(AO.arr[i] + "\t");
            }
            Console.WriteLine("\n\nPrinting alternate elements in array!");
            for (int i = 1; i < 4; i += 2)
            {
                Console.Write(AO.arr[i] + "\t");
            }
            for (int i = 1; i < 5; i++)
            {
                if(AO.arr[i] > max)
                {
                    max = AO.arr[i];
                }
            }
            Console.Write("\n\nLargest number in an array:  "+max);
            for (int i = 1; i < 5; i++)
            {
                if (AO.arr[i] < min)
                {
                    min = AO.arr[i];
                }
            }
            Console.Write("\n\nSmallest number in an array:  " + min);
            Console.WriteLine();
        }
    }
    class ArrayOpsUsingConstructor
    {
        static void Main()
        {
            ArrayOps obj1 = new ArrayOps();
            ArrayOps obj2 = new ArrayOps(obj1);
        }
    }
}