using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoProject
{
    class DictionaryGenericCollection
    {
        static void Main()
        {
            Dictionary<string,int> dict = new Dictionary<string,int>();
            dict.Add("INDIA",91);
            dict.Add("CANADA",1);
            dict.Add("AUSTRALIA",61);
            dict.Add("EGYPT",20);
            dict.Add("ITALY",39);

            Console.WriteLine("Elements in Dictionary are:");
            foreach (KeyValuePair<string,int> kp in dict)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
            Console.WriteLine();

            dict.Add("SRI LANKS", 94);
            dict.Add("ICELAND", 353);
            Console.WriteLine("Elements added in dictionary!");
            Console.WriteLine("Updated Elements in Dictionary are:");
            foreach (KeyValuePair<string, int> kp in dict)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
            Console.WriteLine();

            dict["CANADA"] = 111;
            dict["ITALY"] = 49;
            Console.WriteLine("Elements Updated in dictionary!");
            Console.WriteLine("Updated Elements in Dictionary are:");
            foreach (KeyValuePair<string, int> kp in dict)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
            Console.WriteLine();
            dict.Remove("CANADA");
            dict.Remove("ITALY");
            Console.WriteLine("Couple of elements are deleted!");
            Console.WriteLine("Updated Elements in Dictionary are:");
            foreach (KeyValuePair<string, int> kp in dict)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
            Console.WriteLine();
            dict.Clear();
            Console.WriteLine("Does dictionary empty? : " + (dict.Count==0));
        }
    }
}
