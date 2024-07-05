using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class ArrayAssignment1
    {
        static void DisplayArray(char[] a)
        {
            foreach (char c in a)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
        static void ReverseArray(char[] a)
        {
            char c;
            int i = 0, j = a.Length - 1;
            //Console.WriteLine("\n***USING WHILE LOOP***");
            while (i < j)
            {
                c = a[i];
                a[i] = a[j];
                a[j] = c;
                i++;
                j--;
            }
            //Console.WriteLine("\n***USING FOR LOOP***");
            //for (i = 0; i < j; i++)
            //{
            //    c = a[i];
            //    a[i] = a[j];
            //    a[j] = c;
            //    j--;
            //}
            Console.WriteLine();
        }
        static void Main()
        {
            string str = "CODEMIND TECHNOLOGY";
            //char[] strarray = str.ToCharArray();
            int p = str.Length;
            char[] strarray = new char[p];
            for (int i = 0; i < p; i++)
            {
                strarray[i] = str[i];
            }
            Console.WriteLine("String is: ");
            DisplayArray(strarray);
            ReverseArray(strarray);
            Console.WriteLine("Reverse string is: ");
            DisplayArray(strarray);
        }
    }
}