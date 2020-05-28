using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace Takeaway
{
    class Checkout
    {
        public Dictionary<string, double> List;

        public double Total;
        public Checkout()
        {
            List = new Dictionary<string, double>();
            Total = 0;
        }

        public void Add(Dish dish, int quantity)
        {
            List.Add(dish.Name, (dish.Price * quantity));
        }

        public void Calculate()
        {
            
            foreach (var item in List)
            {
                Total += item.Value;
            }
        }

        public void PrintBill()
        {
            List.Add("Total", Total);
            foreach (KeyValuePair<string, double> item in List)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            //Console.WriteLine("Your total is: " + TotalFormat());
        }

        public void Payment(double totalPaid)
        {
            bool status = TotalFormat().Equals(totalPaid);
            if (status)
            {
               
                Console.WriteLine("Thank you for your purchase");
            }
            else
            {
                Console.WriteLine("Please insert the right amount");
            }
        }

        private string TotalFormat()
        {
            return String.Format("{0:0.00}", Total);
        }
    }
}
