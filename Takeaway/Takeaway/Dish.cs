using System;
using System.Collections.Generic;
using System.Text;

namespace Takeaway
{
    public class Dish
    {
        public string Name;

        public double Price;
        public Dish(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
