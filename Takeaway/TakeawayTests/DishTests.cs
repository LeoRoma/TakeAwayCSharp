using Xunit;
using Takeaway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Takeaway.Tests
{
    public class DishTests
    {
        [Fact()]
        public void DishTest()
        {
            string name = "Margherita";
            double price = 5.50;

            var dish = new Dish("Margherita", 5.50);

            Assert.Equal(name, dish.Name);
            Assert.Equal(price, dish.Price);
        }
    }
}