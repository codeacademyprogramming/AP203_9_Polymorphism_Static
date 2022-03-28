using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Phone:Product
    {
        public int SIMCount { get; set; }

        public override string GetInfo()
        {
            return $"Name: {this.Name} - Price: {this.Price} - SimCount: {this.SIMCount}";
        }
    }
}
