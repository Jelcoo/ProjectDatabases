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
        public void UpdateStock(int productId, int newStockAmount)
        {
            string query = $"UPDATE [products] SET stock = @NewStockAmount WHERE productId = @ProductId";

            using (SqlCommand command = new SqlCommand(query, OpenConnection()))
            {
                command.Parameters.AddWithValue("@NewStockAmount", newStockAmount);
                command.Parameters.AddWithValue("@ProductId", productId);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
        public void UpdateProduct(Product updatedProduct)
        {
            string query = @"UPDATE [products] 
                    SET name = @Name, stock = @Stock, VATRate = @VATRate, price = @Price
                    WHERE productId = @ProductId";

            using (SqlCommand command = new SqlCommand(query, OpenConnection()))
            {
                command.Parameters.AddWithValue("@Name", updatedProduct.Name);
                command.Parameters.AddWithValue("@Stock", updatedProduct.Stock);
                command.Parameters.AddWithValue("@VATRate", updatedProduct.VATRate);
                command.Parameters.AddWithValue("@Price", updatedProduct.Price);
                command.Parameters.AddWithValue("@ProductId", updatedProduct.ProductId);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}
