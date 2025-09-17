using System.ComponentModel.DataAnnotations;

namespace WareHouse.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SKU { get; set; }
        [Required]
        public int Quantity { get; set; }

        public int WarehouseId { get; set; }
    }
}
