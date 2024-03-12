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
    }
}