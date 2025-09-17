using WareHouse.Data.DataContext;
using WareHouse.Data.Models;

namespace WareHouse.BusinessLayer.Interfaces
{
    public class WarehouseRepository
    {
        private readonly ApplicationDbContext _context;
        public WarehouseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Warehouse> GetAll()
        {
            return _context.Warehouses.ToList();
        }

        public Warehouse GetById(int id)
        {
            return _context.Warehouses.Find(id);
        }

        public void Add(Warehouse warehouse)
        {
            _context.Warehouses.Add(warehouse);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
