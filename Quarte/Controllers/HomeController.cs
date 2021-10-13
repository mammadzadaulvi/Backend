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
                //Services = _context.Services.OrderBy(x => x.Order).Take(3).ToList(),
                Statuses = _context.Statuses.ToList(),
                Cities = _context.Cities.ToList(),
                Categories = _context.Categories.ToList(),
                Amenities = _context.Amenities.ToList()
            };
            return View(homeVM);
        }

        //public IActionResult GetProduct(int id)
        //{
        //    Product product = _context.Products.Include(x => x.ProductImages).Include(x => x.Category)
        //        .FirstOrDefault(x => x.Id == id);

        //    return View(homeVM);
        //}

    }
}
