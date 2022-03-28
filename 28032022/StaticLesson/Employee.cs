using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLesson
{
    internal class Employee
    {
        static Employee()
        {
            Console.WriteLine("Static constructor isledi");
        }
        public Employee()
        {
            Count++;
            Console.WriteLine("constructor isledi");
        }

        public Employee(string fullname)
        {
            Count++;

            Console.WriteLine("constructor isledi");

            FullName = fullname;
        }
        public static int Count;
        public string FullName { get; set; }
        public string Positon { get; set; }
        public double Salary { get; set; }
    }
}
