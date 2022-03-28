using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Student:Human
    {
        public string GroupNo { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name} - Surname: {this.Surname} - GroupNo: {this.GroupNo}");
        }
    }
}
