using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class Status
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
