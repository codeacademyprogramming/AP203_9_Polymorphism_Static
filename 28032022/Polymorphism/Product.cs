using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal abstract class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }    

        public virtual string GetInfo()
        {
            return $"Name: {this.Name} - Price: {this.Price}";
        } 
    }
}
