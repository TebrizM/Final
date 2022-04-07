using Final.Models;
using Final.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly HnBandContext _context;
        public HomeController(HnBandContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.OrderBy(x => x.Order).ToList(),
                Settings = _context.Settings.ToDictionary(x => x.Key, x => x.Value),
                Tours = _context.Tours.ToList(),
                AlbumTracks = _context.Tracks.ToList(),
                Albums = _context.Albums.Include(x => x.AlbumTracks).Include(x=>x.Singer).ToList(),


            };

            return View(homeVM);
        }
    }
}
