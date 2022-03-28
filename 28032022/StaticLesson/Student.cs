using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLesson
{
    internal class Student
    {
        public Student()
        {
            _count++;
            No = _count;
        }
        static int _count;
        public int No { get;set; }
        public string FullName { get; set; }
    }
}
