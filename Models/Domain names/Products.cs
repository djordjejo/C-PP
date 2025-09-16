using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Domain_names
{
    public class Products
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required (ErrorMessage = "Product name is required field")]
        public string ProductName{ get; set; }
        [Required(ErrorMessage = "Product price is required field")]

        public decimal Price { get; set; }
        [Required(ErrorMessage = "Product description is required field")]

        public string Description{ get; set; }
        [Required]
        public DateTime StartAt { get; set; }
    }
}
