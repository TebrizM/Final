using Final.Areas.manage.ViewModels;
using Final.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.Controllers
{
    [Area("manage")]
    public class DashboardController : Controller
    {
        private readonly HnBandContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IWebHostEnvironment _env;

        public DashboardController(HnBandContext context, UserManager<AppUser> userManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public IActionResult Index()
        {
            DashboardViewModel dashboardVM = new DashboardViewModel
            {
                Tours = _context.Tours.ToList(),
                Order = _context.Orders.Include(x => x.OrderItems).OrderByDescending(x => x.CreatedAt).Take(5).ToList(),
                Messages = _context.Contacts.ToList(),
                Visitors = _context.Visitors.ToList(),
                Genres = _context.Genres.Include(x=>x.Albums).Take(4).ToList(),

                
               
            };

            return View(dashboardVM);
        }
    }
}
