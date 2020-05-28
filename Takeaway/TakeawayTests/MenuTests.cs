using Xunit;
using Takeaway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Takeaway.Tests
{
    public class MenuTests
    {
        private Dish[] _dishes;
        private Menu _menu;

        [Fact()]
        public void MenuTest()
        {
            _dishes = new Dish[]
            {
                new Dish("Margherita", 5.00),
                new Dish("Boscaiola", 6.50),
                new Dish("Capricciosa", 7.00)
            };

            _menu = new Menu(_dishes);
        }

        [Fact()]
        public void PrintTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}