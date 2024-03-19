using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class ProductService
    {
        private ProductDao productdb;
        private Product selectedProduct; // Declare a private field to store the selected product

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
        public Product GetByIdProduct(Product product)
        {
            productdb.GetByIdProduct(product.ProductId); 
            return product;
        }
        public Product CreateProduct(Product product)
        {
            productdb.CreateProduct(product);
            return product;
        }
        public Product GetSelectedProduct()
        {
            return selectedProduct;
        }
    }
}
