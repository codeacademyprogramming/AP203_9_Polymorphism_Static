using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name} - Surname: {this.Surname}");
        }
    }
}
