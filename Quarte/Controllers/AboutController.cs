using Microsoft.AspNetCore.Mvc;
using Quarte.Models;
using Quarte.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            AboutViewModel aboutVM = new AboutViewModel
            {
                Abouts = _context.Abouts.ToList()
            };

            return View(aboutVM);
        }
    }
}
