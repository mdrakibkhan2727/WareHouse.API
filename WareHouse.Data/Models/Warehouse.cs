using System.ComponentModel.DataAnnotations;

namespace WareHouse.Data.Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!; 

        public string? Location { get; set; }    

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
