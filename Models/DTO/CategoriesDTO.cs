using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class CategoriesDTO
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Required(ErrorMessage = "Category name is required field")]

        public string CategoryName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
