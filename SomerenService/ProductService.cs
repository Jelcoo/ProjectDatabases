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

        public ProductService()
        {
            productdb = new ProductDao();
        }

        public List<Product> GetProducts(string sortBy = null)
        {
            List<Product> products = productdb.GetAll(sortBy);
            return products;
        }
        public void UpdateProductStock(int productId, int newStockAmount)
        {
            productdb.UpdateStock(productId, newStockAmount);
        }

        public void UpdateProduct(Product updatedProduct)
        {
            productdb.UpdateProduct(updatedProduct);
        }
    }
}
