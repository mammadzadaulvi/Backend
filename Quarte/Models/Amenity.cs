using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class Amenity
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 250)]
        public string Name { get; set; }

        [StringLength(maximumLength: 250)]
        public string Icon { get; set; }

        //public List<ProductAmenity> ProductAmenities { get; set; }
    }
}
