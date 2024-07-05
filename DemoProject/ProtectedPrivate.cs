using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class employee
    {
        protected int empid;
        protected string empname,empaddress,empprocess;
        public void SetEmpDetails(int a, string b, string c, string d)
        {
            empid=a;
            empname = b;
            empaddress = c;
            empprocess = d;
        }
    }
    class person : employee
    {
        private string firstname, lastname;
        public void SetName(string a, string b)
        {
            firstname = a;
            lastname = b;
        }
        public void DisplayFullName()
        {
            Console.WriteLine("Employee ID: " + empid);
            Console.WriteLine("Employee Name: " + empname);
            Console.WriteLine("Employee Address: " + empaddress);
            Console.WriteLine("Employee Process: " + empprocess);
            Console.WriteLine();
            Console.WriteLine("Person Name: " + firstname + " " + lastname);
        }
    }
    class ProtectedPrivate
    {
        static void Main()
        {
            person pobj = new person();
            pobj.SetEmpDetails(195699, "Patricia Finn", "Schaumburgh, IL", "RUSHMORE");
            pobj.SetName("Ramesh", "Koshti");
            pobj.DisplayFullName();
        }
    }
}