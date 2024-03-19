using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class ProductService
    {
        private ProductDao productdb;

        public ProductService()
        {
            productdb = new ProductDao();
        }

        public List<Product> GetProducts(string sortBy = null)
        {
            List<Product> products = productdb.GetAll(sortBy);
            return products;
        }

        public void UpdateProduct(Product product)
        {
            productdb.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            productdb.DeleteProduct(product);
        }

        public Product CreateProduct(Product product)
        {
            productdb.CreateProduct(product);
            return product;
        }
    }
}
