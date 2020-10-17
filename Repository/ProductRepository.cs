using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using SampleAPIHost.Models;

namespace SampleAPIHost.Repository
{
    public class ProductRepository : IProductRepository
    {
        List<Models.Products> productList = new List<Products>();
        public Dictionary<string ,List <Models.Products>> finalproduct = new Dictionary<string, List<Models.Products>>();

        public ProductRepository()
        {
            productList.Add(new Products("one", "a", 10, true));
            productList.Add(new Products("two", "a", 10, true));
            productList.Add(new Products("three", "a", 10, true));
            finalproduct.Add( "Battery" , new List<Models.Products> { productList[0],productList[1]});
            finalproduct.Add("Weight", new List<Models.Products> { productList[1] });
            //  finalproduct.Add(new List<string> { "BroadCategory1", "2", "Weight" }, productList[1]);
            //finalproduct.Add(new List<string> { "BroadCategory2", "1", "Battery" }, productList[0]);
            //finalproduct.Add(new List<string> { "BroadCategory2", "3", "Weight" }, productList[1]);

        }

        public void AddNewProduct(Products newProduct)
        {

            productList.Add(newProduct);
          
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return productList;
        }
        public List<Products> GetfinalProducts(string r1,string r2,string r3)
        {
            //string[] finalproducts = new string[] {r1,r2,r3 };
            //var product = finalproduct[finalproducts];
            var product=finalproduct[r3];
            return product;
        }




        // { new List<string>{"BroadCategory1","1","Battery"},productList[0]},






    }
}
