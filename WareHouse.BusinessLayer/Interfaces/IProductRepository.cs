using WareHouse.Data.Models;

namespace WareHouse.BusinessLayer.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetByWarehouseId(int warehouseId);
        void Add(Product product);
        void Save();
    }
}
