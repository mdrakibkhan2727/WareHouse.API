using Microsoft.AspNetCore.Mvc;
using WareHouse.BusinessLayer.Interfaces;
using WareHouse.Data.Models;

namespace WareHouse.API.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseRepository _repo;

        public WarehouseController(IWarehouseRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("warehouses")]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }

        [HttpPost("warehouse")]
        public IActionResult Add(Warehouse warehouse)
        {
            _repo.Add(warehouse);
            _repo.Save();
            return Ok();
        }
    }
}
