using SomerenModel;
using System;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class RevenueDao : BaseDao
    {
        public Revenue GetRevenue(DateTime startDate, DateTime endDate)
        {
            string query = @"
SELECT
    COALESCE(SUM(quantity), 0) AS total_drinks_sold,
    COUNT(DISTINCT studentId) AS unique_customers,
    COALESCE(SUM(orderlines.quantity * products.price), 0) AS turnover
FROM orders
JOIN orderlines ON orders.orderId=orderlines.orderId
JOIN products ON orderlines.productId= products.productId
WHERE orders.orderTimestamp BETWEEN @startDate AND @endDate;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@startDate", $"{startDate:yyyy-MM-dd} 00:00:00");
            command.Parameters.AddWithValue("@endDate", $"{endDate:yyyy-MM-dd} 23:59:59");

            SqlDataReader reader = command.ExecuteReader();
            Revenue revenue = null;

            if (reader.Read())
            {
                revenue = ReadRevenue(reader);
            }

            reader.Close();
            CloseConnection();

            return revenue;
        }

        private Revenue ReadRevenue(SqlDataReader reader)
        {
            reader.GetColumnSchema();
            Revenue revenue = new Revenue(
                (int)reader["total_drinks_sold"],
                (int)reader["unique_customers"],
                (double)reader["turnover"]
            );
            return revenue;
        }
    }
}
