using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Bean Soup", Category = "Grocery", Price = 2 },
            new Product { Id = 2, Name = "Pen", Category = "Stationery", Price = 5M },
            new Product { Id = 3, Name = "Cup", Category = "Mug", Price = 13.00M }
        };

        public ProductsController()
        {
        }
        public ProductsController(Product[] products)
        {
            this.products = products;
        }

        
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}