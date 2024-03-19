using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderTimestamp { get; set; }
        public int StudentId { get; set; }

        public Student Student { get; set; }
        public List<OrderLine> OrderLines { get; set; }

        public double TotalPrice {
            get
            {
                double price = 0;
                foreach (OrderLine line in OrderLines)
                {
                    price += line.Product.Price * line.Quantity;
                }

                return price;
            }
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
