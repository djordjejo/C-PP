using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Domain_names
{
    public class ProductCategories
    {
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }


        public Products Product { get; set; }
        public Categories Category { get; set; }

    }
}
