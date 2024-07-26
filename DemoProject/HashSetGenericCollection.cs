using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class HashSetGenericCollection
    {
        static void Main()
        {
            HashSet<string> HS1 = new HashSet<string>();
            HS1.Add("INDIA");
            HS1.Add("USA");
            HS1.Add("RUSSIA");
            HS1.Add("SRI LANKA");
            HS1.Add("JAPAN");
            Console.WriteLine("First hashset is: ");
            foreach (string item in HS1)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");
            HS1.Add("AUSTRALIA");
            HS1.Add("ICELAND");
            Console.WriteLine("Updated first hashset is: ");
            foreach (string item in HS1)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");
            HS1.Remove("USA");
            HS1.Remove("JAPAN");
            Console.WriteLine("Updated (after deleting couple of elements) first hashset is: ");
            foreach (string item in HS1)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");
            HashSet<string> HS2 = new HashSet<string>();
            HS2.Add("AUSTRALIA");
            HS2.Add("ITALY");
            HS2.Add("EGYPT");
            HS2.Add("BRAZIL");
            HS2.Add("ICELAND");
            Console.WriteLine("Second hashset is: ");
            foreach (string item in HS2)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");
            Console.WriteLine("After intersect with first & second hashset is: ");
            HS1.IntersectWith(HS2);
            //Console.WriteLine(string.Join(",",HS1));
            //HS1.IntersectWith(HS2);
            foreach (string item in HS1)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");
            HS1.UnionWith(HS2);
            Console.WriteLine("After union with first & second hashset is: ");
            foreach (string item in HS1)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");
        }
    }
}
