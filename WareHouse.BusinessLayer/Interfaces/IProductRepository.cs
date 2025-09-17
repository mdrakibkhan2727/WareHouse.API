using WareHouse.Data.Models;

namespace WareHouse.BusinessLayer.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetByWarehouseId(int id);
        void Add(Product product);
        void Save();
    }
}
