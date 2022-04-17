using Final.Areas.manage.ViewModels;
using Final.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "SuperAdmin,Admin")]
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
        public  async Task <IActionResult> Index()
        {
            DashboardViewModel dashboardVM = new DashboardViewModel
            {
                Users = _context.AppUsers.ToList(),
                Tours = _context.Tours.ToList(),
                Order = _context.Orders.Include(x => x.OrderItems).OrderByDescending(x => x.CreatedAt).Take(5).ToList(),
                Messages = _context.Contacts.ToList(),
                Visitors = _context.Visitors.ToList(),
                Albums = _context.Albums.ToList(),
                Genres = _context.Genres.Include(x => x.Albums).Take(4).ToList(),

                JanuaryyUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 1 && !x.IsAdmin).ToListAsync(),
                FebruaryyUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 2 && !x.IsAdmin).ToListAsync(),
                MarchUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 3 && !x.IsAdmin).ToListAsync(),
                AprilUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 4 && !x.IsAdmin).ToListAsync(),
                MayUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 5 && !x.IsAdmin).ToListAsync(),
                JuneUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 6 && !x.IsAdmin).ToListAsync(),
                JulyUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 7 && !x.IsAdmin).ToListAsync(),
                AugustUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 8 && !x.IsAdmin).ToListAsync(),
                SeptemberUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 9 && !x.IsAdmin).ToListAsync(),
                OctoberUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 10 && !x.IsAdmin).ToListAsync(),
                NovemberUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 11 && !x.IsAdmin).ToListAsync(),
                DecemberUsers = await _context.AppUsers.Where(x => x.CreatedAt.Month == 12 && !x.IsAdmin).ToListAsync(),
              
                
               
            };

            return View(dashboardVM);
        }
    }
}
