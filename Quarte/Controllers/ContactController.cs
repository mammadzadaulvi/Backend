using Microsoft.AspNetCore.Mvc;
using Quarte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    ///////////////
        //}
    }
}
