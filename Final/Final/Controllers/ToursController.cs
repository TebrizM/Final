using Final.Models;
using Final.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class ToursController : Controller
    {
        private readonly HnBandContext _context;
        public ToursController(HnBandContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ToursViewModel tourVM = new ToursViewModel
            {
                Tours = _context.Tours.ToList()
            };

            return View(tourVM);
        }
    }
}
