using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{   
    class PublicDemo
    {
        public void ShowMessage()
        {
            Console.WriteLine("Hello from PublicDemo...!");
        }
    }
    class PrivateDemo
    {
        private void ShowSecret()
        {
            Console.WriteLine("This is a secret method...!");
        }
        public void AccessPrivateMethd()
        {
            ShowSecret();
        }
    }
    class InternalDemo
    { 
        internal void ShowInternalMessage()
        {
            Console.WriteLine("This is an internal method...!");
        }
    }
    class AccessModifier
    {
        static void Main()
        {
            PublicDemo a = new PublicDemo();
            a.ShowMessage();
            PrivateDemo b=new PrivateDemo();
            b.AccessPrivateMethd();
            InternalDemo c = new InternalDemo();
            c.ShowInternalMessage();
        }
    }
}
