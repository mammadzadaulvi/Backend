using Microsoft.AspNetCore.Mvc;
using Quarte.Models;
using Quarte.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            TeamViewModel teamVM = new TeamViewModel
            {
                Teams = _context.Teams.ToList()
            };

            return View(teamVM);
        }
    }
}
