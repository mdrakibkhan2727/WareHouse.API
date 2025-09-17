using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Data.DataContext;
using WareHouse.Data.Models;

namespace WareHouse.BusinessLayer.Interfaces
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetByWarehouseId(int warehouseId)
        {
            return _context.Products.Where(p => p.WarehouseId == warehouseId).ToList();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
