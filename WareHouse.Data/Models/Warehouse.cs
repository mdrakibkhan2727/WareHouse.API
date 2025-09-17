﻿using System.ComponentModel.DataAnnotations;

namespace WareHouse.Data.Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }
    }
}
