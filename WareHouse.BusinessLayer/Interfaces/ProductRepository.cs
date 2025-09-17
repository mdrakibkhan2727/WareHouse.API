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

        public IEnumerable<Product> GetByWarehouseId(int id)
        {
            return _context.Products.Where(p => p.Id == id).ToList();
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
