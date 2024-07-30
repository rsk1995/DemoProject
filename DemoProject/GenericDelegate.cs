using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class GenericDelegate
    {
        static string ConcatString(string a, string b)
        {
            return a+" "+b;
        }
        static string PNNumber(int n1)
        {
            if (n1 == 0)
            {
                return "0 is neither negative nor positive...!";
            }
            else if (n1 < 0)
            {
                return "You entered negative number!";
            }
            else
            {
                return "You entered positive number!";
            }
        }
        static bool StrStart(string s1)
        {
            char ch = s1[0];
            if (ch == 'A' || ch == 'a')
            {
                return true;
                //Console.WriteLine("Given string start with letter 'A' or 'a'!");
            }
            else
            {
                return false;
                //Console.WriteLine("Given string not start with letter 'A' or 'a'!");
            }
        }
        static void LogError(string b)
        {
            Console.WriteLine(b + " " + DateTime.Now);
        }
        static void Main()
        {
            string str1,str2;
            Console.WriteLine("Enter two words for concatenate!");
            Console.Write("Enter first word: ");
            str1 = Console.ReadLine();
            Console.Write("Enter second word: ");
            str2 = Console.ReadLine();
            Func<string, string, string> obj1 = ConcatString;
            string a = obj1(str1, str2);
            Console.WriteLine("Concate string is: "+a);
            Console.WriteLine("\nValidate number is negative or positive!");
            Console.Write("Enter any number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Func <int,string> obj2 = PNNumber;
            string pnn = obj2(n);
            Console.WriteLine(pnn);
            Console.Write("\nEnter any string: ");
            str1 = Console.ReadLine();
            Predicate<string> obj3 = StrStart;
            bool bl = obj3(str1);
            if(bl==true)
            Console.WriteLine("Given string start with letter 'A' or 'a'!");
            else
            Console.WriteLine("Given string not start with letter 'A' or 'a'!");
            Action<string> obj4 = LogError;
            obj4("\nAn unexpected error occurred.");
        }
    }
}