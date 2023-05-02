using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async void AddProducts()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id =Guid.NewGuid(), Name = "Product_1", Price = 100, CreatedDate = DateTime.UtcNow, Stock = 100  },
                new(){Id =Guid.NewGuid(), Name = "Product_2", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 200  },
                new(){Id =Guid.NewGuid(), Name = "Product_3", Price = 300, CreatedDate = DateTime.UtcNow, Stock = 300  }
            });

            await _productWriteRepository.SaveAsync();
   
        }
    }
}
