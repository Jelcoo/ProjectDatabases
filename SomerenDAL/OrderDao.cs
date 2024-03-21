using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public int StoreOrder(Order order)
        {
            SqlCommand command = new SqlCommand("INSERT INTO orders (orderTimestamp, studentId) VALUES (CURRENT_TIMESTAMP, @studentId); SELECT SCOPE_IDENTITY();", OpenConnection());
            command.Parameters.AddWithValue("@studentId", order.Student.StudentId);

            int insertedId = Convert.ToInt32(command.ExecuteScalar());
            return insertedId;
        }

        public void StoreOrderLine(int orderId, OrderLine orderLine)
        {
            SqlCommand command = new SqlCommand("INSERT INTO orderlines (orderId, productId, quantity) VALUES (@orderId, @productId, @quantity)", OpenConnection());
            command.Parameters.AddWithValue("@orderId", orderId);
            command.Parameters.AddWithValue("@productId", orderLine.Product.ProductId);
            command.Parameters.AddWithValue("@quantity", orderLine.Quantity);

            command.ExecuteNonQuery();
        }

        private Order ReadOrder(SqlDataReader reader)
        {
            Order order = new Order()
            {
                OrderId = (int)reader["orderId"],
                OrderTimestamp = DateTime.Parse(reader["orderTimestamp"].ToString()),
                StudentId = (int)reader["studentId"],
            };

            return order;
        }

        private OrderLine ReadOrderLine(SqlDataReader reader)
        {
            OrderLine line = new OrderLine()
            {
                OrderItemId = (int)reader["orderItemId"],
                OrderId = (int)reader["orderId"],
                ProductId = (int)reader["productId"],
                Quantity = (int)reader["quantity"],
            };

            return line;
        }
    }
}
