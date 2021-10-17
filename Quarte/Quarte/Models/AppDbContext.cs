﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Amenity> Amenities { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductAmenity> ProductAmenities { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Wishlist> Wishlists { get; set; }
    }
}
