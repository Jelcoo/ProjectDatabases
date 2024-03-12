using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAll(string sortBy = null)
        {
            string query = "SELECT orders.orderId, students.studentId, orders.orderId, orderTimestamp, orderItemId, quantity, [name], stock, VATRate, price, firstName, lastName, phoneNumber, class, vouchers, roomId " +
                "FROM orders " +
                "JOIN orderlines ON orders.orderId = orderlines.orderId " +
                "JOIN students ON orders.studentId = students.studentId;";

            if (sortBy != null)
            {
                query += $" ORDER BY {sortBy}";
            }
            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            List<Order> orders = new List<Order>();
            StudentDao studentdb = new StudentDao();

            while (reader.Read())
            {
                Order order = ReadOrder(reader);
                order.Student = studentdb.ReadStudent(reader);
                order.OrderLines = GetAllOrderlinesForOrder(order.OrderId);

                orders.Add(order);
            }
            reader.Close();
            CloseConnection();

            return orders;
        }

        public List<OrderLine> GetAllOrderlinesForOrder(int orderId)
        {
            string query = "SELECT orderItemId, orderId, productId, quantity " +
                "FROM [orderlines] " +
                "JOIN products ON orderlines.productId = products.productId " +
                "WHERE orderId=@Id;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@Id", orderId);

            SqlDataReader reader = command.ExecuteReader();
            List<OrderLine> orderlines = new List<OrderLine>();
            ProductDao productdb = new ProductDao();

            while (reader.Read())
            {
                OrderLine line = ReadOrderLine(reader);
                line.Product = productdb.ReadProduct(reader);
                orderlines.Add(line);
            }
            reader.Close();
            CloseConnection();

            return orderlines;
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
        public List<Dictionary<string, object>> GetVatSummary(DateTime startDate, DateTime endDate)
        {
            string query = @"
        SELECT 
            p.VATRate AS VATRate,
            SUM(ol.quantity * p.price * p.VATRate) AS VATAmount,
            SUM(ol.quantity) AS TotalProductsSold,
            COUNT(DISTINCT o.orderId) AS NumberOfOrders
        FROM 
            orders o
        JOIN 
            orderlines ol ON o.orderId = ol.orderId
        JOIN 
            products p ON ol.productId = p.productId
        WHERE 
            o.orderTimestamp BETWEEN @startDate AND @endDate
        GROUP BY 
            p.VATRate;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);

            SqlDataReader reader = command.ExecuteReader();
            List<Dictionary<string, object>> vatSummaries = new List<Dictionary<string, object>>();

            while (reader.Read())
            {
                Dictionary<string, object> summary = new Dictionary<string, object>
        {
            { "VATRate", reader["VATRate"] },
            { "VATAmount", reader["VATAmount"] },
            { "TotalProductsSold", reader["TotalProductsSold"] },
            { "NumberOfOrders", reader["NumberOfOrders"] }
        };

                vatSummaries.Add(summary);
            }

            reader.Close();
            CloseConnection();

            return vatSummaries;
        }
        public decimal GetTotalTaxNeeded(DateTime startDate, DateTime endDate)
        {
            string query = @"
        SELECT 
            SUM(ol.quantity * p.price * p.VATRate) AS TotalTaxNeeded
        FROM 
            orders o
        JOIN 
            orderlines ol ON o.orderId = ol.orderId
        JOIN 
            products p ON ol.productId = p.productId
        WHERE 
            o.orderTimestamp BETWEEN @startDate AND @endDate;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);

            decimal totalTaxNeeded = (decimal)command.ExecuteScalar();

            CloseConnection();

            return totalTaxNeeded;
        }
    }
}
