using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class ArrayListAssignment
    {
        static void Main()
        {
            ArrayList arrlst = new ArrayList();
            arrlst.Add("Apple");
            arrlst.Add("Banana");
            arrlst.Add("3.14");
            arrlst.Add("524");
            arrlst.Add("Hello World!");
            Console.WriteLine("Array list elements are: ");
            foreach (var item in arrlst)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine();
            arrlst.Insert(0, "India");
            arrlst.Insert(3, "Grape");
            arrlst.Add(50.65);
            Console.WriteLine();
            Console.WriteLine("Added few elements in array list!");
            Console.WriteLine();
            Console.WriteLine("Updated array list elements are: ");
            foreach (var item in arrlst)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            arrlst.Remove("3.14");
            arrlst.RemoveAt(3);
            Console.WriteLine();
            Console.WriteLine("Deleted few elements in array list!");
            Console.WriteLine();
            Console.WriteLine("Updated array list elements are: ");
            foreach (var item in arrlst)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            arrlst.Clear();
            Console.WriteLine();
            Console.WriteLine("Array list cleared!");
            Console.WriteLine();
            Console.WriteLine("Updated array list elements are: ");
            foreach (var item in arrlst)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Element: 'Ramesh' exist in the ArrayList? " + arrlst.Contains("Ramesh"));
            Console.WriteLine();
        }
    }
}
