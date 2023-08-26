﻿using System.ComponentModel.DataAnnotations;

namespace Inventiny.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        [Required(ErrorMessage = "The inventory name is required")]
        public string InventoryName { get; set; } = String.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater or equal to 0.")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Price must be greater or equal to 0.")]
        public double Price { get; set; }
    }
}