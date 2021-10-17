using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quarte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin,SuperAdmin")]

    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Models.Service> services = _context.Services.ToList();

            return View(services);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Service service)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Services.Add(service);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Models.Service service = _context.Services.FirstOrDefault(x => x.Id == id);

            if (service == null) return NotFound();

            return View(service);
        }

        [HttpPost]
        public IActionResult Edit(Models.Service service)
        {
            Models.Service existService = _context.Services.FirstOrDefault(x => x.Id == service.Id);

            if (existService == null) return NotFound();

            existService.Title = service.Title;
            existService.Icon = service.Icon;
            existService.Order = service.Order;
            existService.Desc = service.Desc;
            existService.RedirectUrl = service.RedirectUrl;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult DeleteFetch(int id)
        {
            Quarte.Models.Service service = _context.Services.FirstOrDefault(x => x.Id == id);

            if (service == null) return Json(new { status = 404 });

            try
            {
                _context.Services.Remove(service);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return Json(new { status = 500 });
            }

            return Json(new { status = 200 });
        }
    }
}
