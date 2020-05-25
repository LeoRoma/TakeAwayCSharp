using System;
using System.Collections.Generic;
using System.Text;

namespace Takeaway
{
    public class Menu
    {
        public readonly Dish[] Dishes;

        public Menu(Dish[] dishes)
        {
            Dishes = dishes;
        }

        public void Print()
        {
            foreach(Dish dish in Dishes)
            {
                Console.WriteLine($"Name: {dish.Name}, Price: {dish.Price}");
            }
        }
    }
}
