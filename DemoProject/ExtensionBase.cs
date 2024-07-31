using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace DemoProject
{
    internal class ExtensionBase
    {
        internal double a, b, c;
        public void ExtAdd(double x, double y, double z)
        {
            a=x; b=y; c=z;
            Console.WriteLine("Addition of three numbers: " + (x+y+z));
        }
    }
}