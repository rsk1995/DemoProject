using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class EmpDetails
    {
        string name, address;
        protected EmpDetails()
        {
            name = "Ramesh Koshti";
            address = "Solapur";
        }
        protected void DisplayEmpDetails()
        {
            Console.WriteLine($"Employee Name: {name} \nEmployee Address: {address}");
        }
    }
    sealed class EmpSal : EmpDetails
    {
        float sal;
        internal EmpSal()
        {
            sal = 27425.37f;
        }
        internal void DisplayEmpSalary()
        {
            base.DisplayEmpDetails();
            Console.WriteLine("Employee Salary: "+sal);
        }
    }

    internal class SealedClassExample
    {
        static void Main()
        {
            EmpSal emps = new EmpSal();
            emps.DisplayEmpSalary();
        }
    }
}