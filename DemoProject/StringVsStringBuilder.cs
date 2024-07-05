using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class StringVsStringBuilder
    {
        static void Main()
        {
            //using string
            string str = "Hello";
            str += " World";
            str += "!";
            Console.WriteLine(str);
            Console.WriteLine();

            //using string builder
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World");
            sb.Append("!");
            Console.WriteLine(sb);
            Console.WriteLine();

            //difference betweek string and string builder
            //using string
            const int iteration = 50000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string str2 = "";
            for (int i = 0; i < iteration; i++)
            {
                str2 += " Hello";
            }
            sw.Stop();
            Console.WriteLine("Using String: "+sw.ElapsedMilliseconds);
            Console.WriteLine();

            //using string builder
            sw.Reset();
            sw.Start();
            StringBuilder sp2 = new StringBuilder();
            for (int i = 0; i < iteration; i++)
            {
                sp2.Append(" Hello");
            }
            sw.Stop();
            Console.WriteLine("Using String Builder: " + sw.ElapsedMilliseconds);
            Console.WriteLine();
        }
    }
}
