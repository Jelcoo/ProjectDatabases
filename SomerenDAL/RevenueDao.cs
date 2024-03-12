using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class RevenueDao : BaseDao
    {
        public RevenueDao()
        {
            string query = "SELECT SUM(quantity) AS total_drinks_sold, COUNT(DISTINCT studentId) AS unique_customers, SUM(orderlines.quantity * products.price) AS turnover " +
            "FROM orders " +
            "JOIN orderlines ON orders.orderId=orderlines.orderId " +
            "JOIN products ON orderlines.productId= products.productId " +
            "WHERE orders.orderTimestamp BETWEEN '2024-01-10' AND '2024-12-24';";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Revenue revenue= Readrevenue(reader);
            }
            reader.Close();
            CloseConnection();
        }
        private Revenue Readrevenue(SqlDataReader reader)
        {
            Revenue revenue = new Revenue()
            {
                TotalDrinksSold = (int)reader["total_drinks_sold"],
                UniqueCustomers = (int)reader["unique_customers"],
                Turnover = (int)reader["turnover"]
            };
            return revenue;
        }
    }
}
