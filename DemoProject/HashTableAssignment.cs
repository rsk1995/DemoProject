using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class HashTableAssignment
    {
        static void Main()
        {
            Hashtable myHashtable = new Hashtable();
            myHashtable.Add(91, "INDIA");
            myHashtable.Add(1, "CANADA");
            myHashtable.Add(61, "AUSTRALIA");
            myHashtable.Add(20, "EGYPT");
            myHashtable.Add(39, "ITALY");
            //object value1 = myHashtable;
            Console.WriteLine(myHashtable.Keys + "\t" + myHashtable.Values);
            //string val1 = (string)myHashtable[91];
            //string val2 = (string)myHashtable[1];
            //string val3 = (string)myHashtable[61];
            //string val4 = (string)myHashtable[20];
            //string val5 = (string)myHashtable[39];
            //Console.WriteLine("Elements in hashtable are: ");
            //Console.WriteLine(val1);
            //Console.WriteLine(val2);
            //Console.WriteLine(val3);
            //Console.WriteLine(val4);
            //Console.WriteLine(val5);
            //Console.WriteLine();
            //myHashtable.Add(94, "SRI LANKA");
            //myHashtable.Add(353, "ICELAND");
            //string val6 = (string)myHashtable[94];
            //string val7 = (string)myHashtable[353];
            //Console.WriteLine("Two elements added in hashtable!");
            //Console.WriteLine("Elements in hashtable are: ");
            //Console.WriteLine(val1);
            //Console.WriteLine(val2);
            //Console.WriteLine(val3);
            //Console.WriteLine(val4);
            //Console.WriteLine(val5);
            //Console.WriteLine(val6);
            //Console.WriteLine(val7);
            //Console.WriteLine();
            //myHashtable.Remove(20);
            //myHashtable.Remove(94);
            //Console.WriteLine("Two elements are deleted from hashtable!");
            //Console.WriteLine("Elements in hashtable are: ");
            //Console.WriteLine((string)myHashtable[91]);
            //Console.WriteLine((string)myHashtable[1]);
            //Console.WriteLine((string)myHashtable[61]);
            //Console.WriteLine((string)myHashtable[20]);
            //Console.WriteLine((string)myHashtable[39]);
            //Console.WriteLine((string)myHashtable[94]);
            //Console.WriteLine((string)myHashtable[353]);
            //myHashtable.Clear();
        }
    }
}