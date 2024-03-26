using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public Student Student { get; set; }
        public List<OrderLine> OrderLines { get; set; }

        public double TotalPrice() {
            double price = 0;
            foreach (OrderLine line in OrderLines)
            {
                price += line.Product.Price * line.Quantity;
            }

            return price;
        }

        public override string ToString()
        {
            string orderString = "";
            foreach (OrderLine line in OrderLines)
            {
                orderString += $"{line.ToString()}\n";
            }

            return orderString;
        }
    }
}
