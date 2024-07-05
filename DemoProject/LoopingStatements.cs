using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class LoopingStatements
    {
        static void Main()
        {
            Console.WriteLine("***10 Students using FOR loop***");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Student: "+(i+1));
            }
            Console.WriteLine("\n***10 Students using WHILE loop***");
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine("Student: " + (a + 1));
                a++;
            }
            Console.WriteLine("\n***10 Students using DO---WHILE loop***");
            a = 0;
            do
            {
                Console.WriteLine("Student: " + (a + 1));
                a++;
            }while (a < 10);
            Console.WriteLine("\n***List of 10 CELL phone brands***");
            string[] MobileBrands = {"Apple","MI","ONE+","OPPO","VIVO","NOTHING","realme","Gpixel","SAMSUNG","Huawei"};
            foreach (string str in MobileBrands)
            {
                Console.WriteLine(str);
            }
        }
    }
}
