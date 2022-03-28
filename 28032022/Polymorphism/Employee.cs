using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Employee:Human
    {
        public string Position { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name} - Surname: {this.Surname} - Position: {this.Position}");
        }
    }
}
