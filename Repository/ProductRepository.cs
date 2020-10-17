using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleAPIHost.Models;

namespace SampleAPIHost.Repository
{
    public class ProductRepository : IProductRepository
    {
        List<Models.Products> productList = new List<Products>();

        public ProductRepository()
        {
            productList.Add(new Products("one", "a", 10, true));
            productList.Add(new Products("two", "a", 10, true));
            productList.Add(new Products("three", "a", 10, true));
        }

        public void AddNewProduct(Products newProduct)
        {

            productList.Add(newProduct);
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return productList;
        }
    }
}
