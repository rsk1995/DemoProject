﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class ListGenericCollections
    {
        static void Main()
        {
            List<string> lst = new List<string>();
            lst.Add("RAMESH");
            lst.Add("SARVESH");
            lst.Add("KIRAN");
            lst.Add("AMOL");

            Console.WriteLine("List elements are: ");
            foreach (string item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            lst.Insert(1, "RAJ");
            lst.Insert(4, "MAYUR");

            Console.WriteLine("Updated list elements are: ");
            foreach (string item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            lst.RemoveAt(0);          

            Console.WriteLine("Updated list (after deleting) elements are: ");
            foreach (string item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Does list contain 'RAJ'? : " + lst.Contains("RAJ"));
            Console.WriteLine("How many elements in list? : " + lst.Count);
            lst.Clear();
            Console.WriteLine("List cleared!");
            Console.WriteLine("How many elements in list? : " + lst.Count);
        }
    }
}