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
            string query = @"
INSERT INTO orders (orderTimestamp, studentId)
VALUES (CURRENT_TIMESTAMP, @studentId);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
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

        public List<Dictionary<string, object>> GetVatSummary(DateTime startDate, DateTime endDate)
        {
            string query = @"
SELECT p.VATRate AS VATRate,
    SUM(ol.quantity * p.price * p.VATRate) AS VATAmount,
    SUM(ol.quantity) AS TotalProductsSold,
    COUNT(DISTINCT o.orderId) AS NumberOfOrders
FROM orders o
JOIN orderlines ol ON o.orderId = ol.orderId
JOIN products p ON ol.productId = p.productId
WHERE o.orderTimestamp BETWEEN @startDate AND @endDate
GROUP BY p.VATRate;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);

            SqlDataReader reader = command.ExecuteReader();
            List<Dictionary<string, object>> vatSummaries = new List<Dictionary<string, object>>();

            while (reader.Read())
            {
                Dictionary<string, object> summary = ReadSummary(reader);
                vatSummaries.Add(summary);
            }

            reader.Close();
            CloseConnection();

            return vatSummaries;
        }

        public Dictionary<string, object> ReadSummary(SqlDataReader reader)
        {
            Dictionary<string, object> summary = new Dictionary<string, object>
            {
                { "VATRate",  reader["VATRate"] },
                { "VATAmount",  reader["VATAmount"]},
                { "TotalProductsSold",  reader["TotalProductsSold"] },
                { "NumberOfOrders",  reader["NumberOfOrders"] }
            };

            return summary;
        }

        public double GetTotalTaxNeeded(DateTime startDate, DateTime endDate)
        {
            string query = @"
SELECT SUM(ol.quantity * p.price * p.VATRate) AS TotalTaxNeeded
FROM orders o
JOIN orderlines ol ON o.orderId = ol.orderId
JOIN products p ON ol.productId = p.productId
WHERE o.orderTimestamp BETWEEN @startDate AND @endDate;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);

            object result = command.ExecuteScalar();
            double totalTaxNeeded = 0;

            if (result != DBNull.Value)
            {
                totalTaxNeeded = Convert.ToDouble(result);
            }

            CloseConnection();

            return totalTaxNeeded;
        }

    }
}
