using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [StringLength(maximumLength: 250)]
        public string Image { get; set; }
        public bool IsPoster { get; set; }
        public Product Product { get; set; }
    }
}
