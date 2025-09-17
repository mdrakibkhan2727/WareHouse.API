using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Data.Models;

namespace WareHouse.BusinessLayer.Interfaces
{
    public interface IWarehouseRepository
    {
        IEnumerable<Warehouse> GetAll();
        Warehouse GetById(int id);
        void Add(Warehouse warehouse);
        void Save();
    }
}
