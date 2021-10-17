using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Quarte.Models;
using Quarte.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Controllers
{
    public class HomeController : Controller
    {


        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.OrderBy(x => x.Order).ToList(),
                Abouts = _context.Abouts.ToList(),
                Statuses = _context.Statuses.ToList(),
                Cities = _context.Cities.ToList(),
                Categories = _context.Categories.ToList(),
                Amenities = _context.Amenities.ToList()
            };

            var products = _context.Products.ToList();
            double totalArea = 0;
            int totalSold = 0;
            int totalRooms = 0;

            foreach (var item in products)
            {
                totalArea += item.HomeArea;
                totalRooms += item.Rooms;
            }

            ViewBag.TotalArea = totalArea;
            ViewBag.TotalSold = totalSold;
            ViewBag.TotalCount = products.Count();
            ViewBag.TotalRooms = totalRooms;


            return View(homeVM);
        }

        public IActionResult Search(int id)
        {
            Product product = _context.Products
                .Include(x => x.ProductImages).Include(x => x.Category)
                .Include(x => x.ProductAmenities).ThenInclude(x => x.Amenity)
                .FirstOrDefault(x => x.Id == id);

            return View();
        }
    }

}
