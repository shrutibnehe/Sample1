using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleAPIHost.Models;

namespace SampleAPIHost.Repository
{
    public interface IProductRepository
    {
        public void AddNewProduct(Products newProduct);
        public IEnumerable<Products> GetAllProducts();
        public List<Products> GetfinalProducts(string r1,string r2,string r3);
    }
}
