using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class ProductDao : BaseDao
    {
        public List<Product> GetAll()
        {
            SqlCommand command = new SqlCommand("SELECT productId, name, stock, VATRate, price FROM [products] WHERE deleted=0", OpenConnection());

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

        public void DecreaseStock(OrderLine orderLine)
        {
            SqlCommand command = new SqlCommand("UPDATE products SET stock = stock - @quantity WHERE productId = @productId", OpenConnection());
            command.Parameters.AddWithValue("@quantity", orderLine.Quantity);
            command.Parameters.AddWithValue("@productId", orderLine.Product.ProductId);

            command.ExecuteNonQuery();
        }

        public Product ReadProduct(SqlDataReader reader)
        {
            Product product = new Product(
                (int)reader["productId"],
                (string)reader["name"],
                (int)reader["stock"],
                (double)reader["VATRate"],
                (double)reader["price"]
            );

            return product;
        }

        public void UpdateProduct(Product product)
        {
            string query = @"
UPDATE [products]
SET
    name = @Name,
    stock = @Stock,
    VATRate = @VATRate,
    price = @Price
WHERE productId = @ProductId";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.Parameters.AddWithValue("@VATRate", product.VATRate);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@ProductId", product.ProductId);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public int CreateProduct(Product product)
        {
            string query = @"
INSERT INTO products (name, stock, VATRate, price)
VALUES (@Name, @Stock, @VATRate, @Price);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.Parameters.AddWithValue("@VATRate", product.VATRate);
            command.Parameters.AddWithValue("@Price", product.Price);

            int id = Convert.ToInt32(command.ExecuteScalar());

            CloseConnection();

            return id;
        }

        public void DeleteProduct(Product product)
        {
            SqlCommand command = new SqlCommand("UPDATE products SET deleted=1 WHERE productId=@ProductId", OpenConnection());
            command.Parameters.AddWithValue("@ProductId", product.ProductId);

            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
