using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class ProductDao : BaseDao
    {
        public List<Product> GetAll(string sortBy = null)
        {
            string query = "SELECT productId, name, stock, VATRate, price FROM [products]";

            if (sortBy != null)
            {
                query += $" ORDER BY {sortBy}";
            }
            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = ReadProduct(reader);
                products.Add(product);
            }
            reader.Close();
            CloseConnection();

            return products;
        }

        public Product ReadProduct(SqlDataReader reader)
        {
            Product product = new Product()
            {
                ProductId = (int)reader["productId"],
                Name = reader["name"].ToString(),
                Stock = (int)reader["stock"],
                VATRate = (double)reader["VATRate"],
                Price = (double)reader["price"],
            };

            return product;
        }
    }
}
