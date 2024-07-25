using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StackNonGenericCollection
    {
        static void Main()
        {
            Stack stk = new Stack();
            stk.Push("PAT");
            stk.Push(3.14);
            stk.Push("India");
            stk.Push("35.26");
            stk.Push("Hello World!");

            Console.WriteLine("Stack elements are: ");
            foreach (Object stk2 in stk)
            {
                Console.WriteLine(stk2);
            }
            Console.WriteLine();

            stk.Pop();

            Console.WriteLine("1 element deleted!");
            Console.WriteLine("Updated stack elements are: ");
            foreach (Object stk2 in stk)
            {
                Console.WriteLine(stk2);
            }
            Console.WriteLine();

            stk.Clear();
            Console.WriteLine("Is stack empty? " + (stk.Count==0));
            Console.WriteLine();
        }
    }
}