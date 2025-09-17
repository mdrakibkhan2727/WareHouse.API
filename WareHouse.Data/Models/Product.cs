using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;  

        [Required]
        public string SKU { get; set; } = null!;  

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }

        // Navigation property
        public Warehouse? Warehouse { get; set; }
    }
}
