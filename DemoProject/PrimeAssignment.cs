using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class PrimeAssignment
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int flag = 0, cnt=0;
            Console.WriteLine("Below are the prime numbers between 1 to 13!\n");
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(arr[i]);
                    cnt++;
                }
                flag = 0;
            }
            Console.WriteLine($"\nTotal {cnt} prime numbers found!");
        }
    }
}
