using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class SearchStringInArray
    {
        static void Main()
        {
            int MCnt = 0;
            string[] str = { "Alice", "Bob", "Charlie", "David", "Emily", "Bob", "David", "Bob" };
            foreach (string a in str)
            {
                Console.Write("   " + a);
            }
            Console.WriteLine();
            string Search="";
            Console.Write("Enter search string: ");
            Search = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == Search)
                {
                    MCnt++;
                }
            }
            if (MCnt > 0)
            {
                Console.WriteLine("We found {0}, {1} times!", Search, MCnt);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Unable to find given string: {0}.", Search);
                Console.WriteLine();
            }
        }
    }
}
