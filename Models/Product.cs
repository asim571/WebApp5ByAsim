using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp5ByAsim.Models
{
    public partial class Product
    {
        [Required(ErrorMessage = "Id is required.")]
        public decimal Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters.")]
        public string? Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public double? Price { get; set; }
    }
}
