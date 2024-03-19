using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class RevenueDao : BaseDao
    {
        public Revenue GetRevenue(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT COALESCE(SUM(quantity), 0) AS total_drinks_sold, COUNT(DISTINCT studentId) AS unique_customers, COALESCE(SUM(orderlines.quantity * products.price), 0) AS turnover " +
            "FROM orders " +
            "JOIN orderlines ON orders.orderId=orderlines.orderId " +
            "JOIN products ON orderlines.productId= products.productId " +
            $"WHERE orders.orderTimestamp BETWEEN '{startDate:yyyy-MM-dd} 00:00:01' AND '{endDate:yyyy-MM-dd} 23:59:59';";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            SqlDataReader reader = command.ExecuteReader();

            Revenue revenue = null;
            if (reader.Read())
            {
                revenue = Readrevenue(reader);
            }

            reader.Close();
            CloseConnection();

            return revenue;
        }
        private Revenue Readrevenue(SqlDataReader reader)
        {
            reader.GetColumnSchema();
            Revenue revenue = new Revenue()
            {
                TotalDrinksSold = (int)reader["total_drinks_sold"],
                UniqueCustomers = (int)reader["unique_customers"],
                Turnover = (double)reader["turnover"]
            };
            return revenue;
        }
    }
}
