using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    static class CatWorld
    {
        static int NumberOfCats = 5;
        static int TotalCatNaps = 3;
        internal static void add()
        {
            NumberOfCats++;
            Console.WriteLine("A new cat has joined.");
            Console.WriteLine();
        }
        internal static void Display()
        {
            Console.WriteLine("Total number of cats: "+NumberOfCats);
            Console.WriteLine(TotalCatNaps + " cats are naping.");
            Console.WriteLine();
        }
    }

    internal class StaticClassExample
    {
        static void Main()
        {
            CatWorld.Display();
            CatWorld.add();
            CatWorld.Display();
        }
    }
}