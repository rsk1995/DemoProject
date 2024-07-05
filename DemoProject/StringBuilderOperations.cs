using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StringBuilderOperations
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder("EXL ");
            Console.WriteLine(str);
            str.Append("SERVICES ");
            Console.WriteLine(str);
            str.Append("PVT. ");
            Console.WriteLine(str);
            str.Append("lTD. ");
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("Add INDIA in above string after SERVICES\n");
            str.Insert(13, "INDIA ");
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("Replace INDIA as (I) in above string\n");
            str.Replace("INDIA", "(I)", 13, 5);
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("Remove (I) from above string\n");
            str.Remove(13, 4);
            Console.WriteLine(str);
            Console.WriteLine();
        }
    }
}
