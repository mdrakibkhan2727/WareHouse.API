using Microsoft.AspNetCore.Mvc;
using WareHouse.BusinessLayer.Interfaces;
using WareHouse.Data.Models;

namespace WareHouse.API.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("warehouses/{id}/inventory")]
        public IActionResult GetByWarehouse(int id)
        {
            return Ok(_repo.GetByWarehouseId(id));
        }

        [HttpPost("products")]
        public IActionResult Add(Product product)
        {
            _repo.Add(product);
            _repo.Save();
            return Ok();
        }
    }
}
