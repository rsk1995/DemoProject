using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Person1
    {
        protected string Name;
        protected int Age;
    }
    class Student1 : Person1
    {
        public void NewGetSet(string a, int b)
        {
            Name = a;
            Age = b;
        }
        public void Display1()
        {
            Console.WriteLine("Single Inheritance...!");
            Console.WriteLine("Student Name: "+Name);
            Console.WriteLine("Student Age: " + Age);
            Console.WriteLine();
        }
    }
    class Teacher1 : Person1
    {
        public void NewGetSet(string a, int b)
        {
            Name = a;
            Age = b;
        }
        public void Display1()
        {
            Console.WriteLine("Single Inheritance...!");
            Console.WriteLine("Teacher Name: " + Name);
            Console.WriteLine("Teacher Age: " + Age);
            Console.WriteLine();
        }
    }
    class Principal : Teacher1
    {
        public void NewGetSet(string a, int b)
        {
            Name = a;
            Age = b;
        }
        public void Display1()
        {
            //Console.WriteLine("Miltilevel Inheritance...!");
            Console.WriteLine("Principle Name: " + Name);
            Console.WriteLine("Principle Age: " + Age);
            Console.WriteLine();
        }
        public void Property()
        {
            Console.WriteLine("Miltilevel Inheritance...!");
            Console.WriteLine("I am principal");
            //Console.WriteLine();
        }
    }

    class Inheritance
    {
        static void Main()
        {
            Student1 S1 = new Student1();
            S1.NewGetSet("RAMESH KOSHTI", 29);
            S1.Display1();
            Teacher1 T1 = new Teacher1();
            T1.NewGetSet("MAHESH SAWANT", 32);
            T1.Display1();
            Principal P1 = new Principal();
            P1.Property();
            P1.NewGetSet("Patricia Lynn", 43);
            P1.Display1();
            Console.WriteLine();
        }
    }
}