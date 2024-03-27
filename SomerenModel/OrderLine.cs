using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class OrderLine
    {
        public Order Order { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }

        public OrderLine(Order order, Product product, int quantity)
        {
            Order = order;
            Product = product;
            Quantity = quantity;
        }

        public void IncreaseQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public override string ToString()
        {
            return $"{Quantity}x {Product.Name} (€{Product.Price:0.00}; {Product.VATRate}%)";
        }
    }
}
