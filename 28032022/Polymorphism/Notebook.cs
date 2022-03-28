using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Notebook:Product,ISellable
    {
        public int RAM { get; set; }
        public int Storage { get; set; }

        public override string GetInfo()
        {
            return $"Name: {this.Name} - Price: {this.Price} - RAM: {this.RAM} - Storage: {this.Storage}";
        }

        public void Sell()
        {
            Console.WriteLine("Notebook satildi");
        }
    }
}
