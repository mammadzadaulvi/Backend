using Microsoft.AspNetCore.Mvc;
using Quarte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Service> services = _context.Services.Skip(3).Take(5).ToList();

            return View(services);
        }
    }
}
