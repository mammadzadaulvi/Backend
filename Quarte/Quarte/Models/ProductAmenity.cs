﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class ProductAmenity
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int AmenityId { get; set; }

        public Amenity Amenity { get; set; }
    }
}
