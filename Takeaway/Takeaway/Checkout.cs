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
            List.Add("Total", TotalFormat());
            foreach (KeyValuePair<string, double> item in List)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }

        public void Payment(double totalPaid)
        {
            double difference = Math.Abs(TotalFormat() * .00001);

            if (Math.Abs(TotalFormat() - totalPaid) <= difference)
            {
                Console.WriteLine("Thank you for your purchase!");
            }
            else
            {
                throw new Exception("Please insert the right amount");
            }
        }

        private double TotalFormat()
        {
            return Math.Round((Double)Total, 2);
        }
    }
}
