﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TeamId { get; set; }
        public int StatusId { get; set; }
        public int CityId { get; set; }

        [Required]
        public bool IsFeatured { get; set; }

        [Required]
        [StringLength(maximumLength: 250)]
        public string Name { get; set; }

        [Required]
        public double CostPrice { get; set; }

        [Required]
        public double SalePrice { get; set; }

        [StringLength(maximumLength: 250)]
        public string Desc { get; set; }

        [Required]
        public int Rooms { get; set; }

        public int Beds { get; set; }

        public int Baths { get; set; }

        [Required]
        public double HomeArea { get; set; }

        [Required]
        public int Rate { get; set; }

        public DateTime CreatedAt { get; set; }

        [StringLength(maximumLength: 250)]
        public string Location { get; set; }

        public int WhichFloor { get; set; }

        public int HouseFloor { get; set; }

        public Category Category { get; set; }
        public Team Team { get; set; }
        public City City { get; set; }
        public Status Status { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductAmenity> ProductAmenities { get; set; } = new List<ProductAmenity>();


        [NotMapped]
        public IFormFile PosterFile { get; set; }

        [NotMapped]
        public List<IFormFile> ImageFiles { get; set; }

        [NotMapped]
        public List<int> ProductImageIds { get; set; } = new List<int>();

        [NotMapped]
        public List<int> AmenityIds { get; set; } = new List<int>();




    }
}
