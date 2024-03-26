using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class OrderLine
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set;}
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

        public OrderLine(Order order, Product product, int quantity)
        {
            Order = order;
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Quantity}x {Product.Name} (€{Product.Price:0.00}; {Product.VATRate}%)";
        }
    }
}
