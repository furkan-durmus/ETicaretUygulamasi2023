using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new()
            {
                new Product { Id = Guid.NewGuid(), Name = "Product 1",CreatedDate = DateTime.Now , Price = 200 , Stock  = 500}, 
                new Product { Id = Guid.NewGuid(), Name = "Product 2",CreatedDate = DateTime.Now , Price = 300 , Stock  = 500}, 
                new Product { Id = Guid.NewGuid(), Name = "Product 3",CreatedDate = DateTime.Now , Price = 100 , Stock  = 500}, 
                new Product { Id = Guid.NewGuid(), Name = "Product 4",CreatedDate = DateTime.Now , Price = 700 , Stock  = 500}, 
            };
        }
    }
}
