using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class PrimeNumbers
    {
        static void Main()
        {
            int cnt = 0, num=2,flag=0;
            while (cnt < 50)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(num);
                    cnt++;
                }
                flag = 0;
                num++;
            }
        }

        
    }
}
