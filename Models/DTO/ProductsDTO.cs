using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class ProductsDTO
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required(ErrorMessage = "Product name is required field")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Product price is required field")]

        public decimal Price { get; set; }
        [Required(ErrorMessage = "Product description is required field")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Product quantity is required field")]
        public int StockQuantity { get; set; }

        [Required]
        public DateTime StartAt { get; set; }
    }
}
