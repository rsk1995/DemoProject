using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DemoProject
{
    class ArrayAssignment2
    {
        static void DisplayArray(int[] a)
        {
            Console.WriteLine("Array elements are: ");
            foreach (var c in a)
            {
                Console.Write(c+"\t");
            }
            Console.WriteLine();
        }
        static void EvenArrayElements(int[] a)
        {
            Console.WriteLine("Even numbers in array: ");
            foreach (var c in a)
            {
                if (c % 2 == 0)
                {
                    Console.Write(c+"\t");
                }
            }
            Console.WriteLine();
        }
        static void OddArrayElements(int[] a)
        {
            Console.WriteLine("Odd numbers in array: ");
            foreach (var c in a)
            {
                if (c % 2 != 0)
                {
                    Console.Write(c + "\t");
                }
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int i=0;
            int[] IntArray= new int[10];
            while (i < 10)
            {
                Console.Write("Enter array element: ");
                IntArray[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine();
            DisplayArray(IntArray);
            Console.WriteLine();
            EvenArrayElements(IntArray);
            Console.WriteLine();
            OddArrayElements(IntArray);
            Console.WriteLine();
        }
    }
}
