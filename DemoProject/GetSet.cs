using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Person
    {
        public string FullName;// { get; set; }
        public string Country;// { get; set; }
        public Person(string a, string b)
        {
            FullName = a;
            Country = b;

        }
    }

    class GetSet
    {
        static void Main()
        {
            Person p = new Person("RAMESH S KOSHTI","INDIA");
            Console.WriteLine($"Person Name: {p.FullName}, from Country: {p.Country}");
        }
    }
}
