using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WareHouse.BusinessLayer.Interfaces;
using WareHouse.Data.Models;

namespace WareHouse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("{warehouseId}")]
        public IActionResult GetByWarehouse(int warehouseId)
        {
            return Ok(_repo.GetByWarehouseId(warehouseId));
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _repo.Add(product);
            _repo.Save();
            return Ok();
        }
    }
}
