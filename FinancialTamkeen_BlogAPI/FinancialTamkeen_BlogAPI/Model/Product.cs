﻿using System.ComponentModel.DataAnnotations;

namespace FinancialTamkeen_BlogAPI.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int Quantity { get; set; }


    }
}
