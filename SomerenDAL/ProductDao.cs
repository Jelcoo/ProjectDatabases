using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
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
        public Product GetByIdProduct(int productId)
        {
            string query = "SELECT * FROM Products WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@Id", productId);

            SqlDataReader reader = command.ExecuteReader();
            Product product = null;
            if (reader.Read())
            {
                product = ReadProduct(reader);
            }
            reader.Close();
            CloseConnection();
            return product;
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
        public void UpdateProduct(Product product)
        {
            string query = @"UPDATE [products] 
                    SET name = @Name, stock = @Stock, VATRate = @VATRate, price = @Price
                    WHERE productId = @ProductId";

            using (SqlCommand command = new SqlCommand(query, OpenConnection()))
            {
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                command.Parameters.AddWithValue("@VATRate", product.VATRate);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@ProductId", product.ProductId);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
        public Product CreateProduct(Product product)
        {
            string query = $"INSERT INTO products (name, stock, VATRate, price) VALUES (@Name, @Stock, @VATRate, @Price); SELECT SCOPE_IDENTITY();";

            using (SqlCommand command = new SqlCommand(query, OpenConnection()))
            {
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                command.Parameters.AddWithValue("@VATRate", product.VATRate);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.ExecuteNonQuery();

                int id = Convert.ToInt32(command.ExecuteScalar());
                product.ProductId = id;
            }
            CloseConnection();
            return product;
        }
        public void DeleteProduct(Product product)
        {
            string query = $"DELETE FROM Products WHERE ProductId = @Id";

            using (SqlCommand command = new SqlCommand(query, OpenConnection()))
            {
                command.Parameters.AddWithValue("@Id", product.ProductId);
                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}
