﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public Student Student { get; private set; }
        public List<OrderLine> OrderLines { get; private set; }

        public Order(Student student) {
            Student = student;
            OrderLines = new List<OrderLine>();
        }

        public double TotalPrice() {
            double price = 0;
            foreach (OrderLine line in OrderLines)
            {
                price += line.Product.Price * line.Quantity;
            }

            return price;
        }

        public void AddOrderLine(OrderLine orderLine) {
            OrderLines.Add(orderLine);
        }

        public override string ToString()
        {
            if (OrderLines.Count == 0)
            {
                return "No items in order";
            }

            string orderString = "";
            foreach (OrderLine line in OrderLines)
            {
                orderString += $"{line.ToString()}\n";
            }

            return orderString;
        }
    }
}
