using Final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class SettingsController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;
        public SettingsController(HnBandContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            string pageSizestr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;

            int pageSize = string.IsNullOrWhiteSpace(pageSizestr) ? 3 : int.Parse(pageSizestr);

            return View(PaginatedList<Settings>.Create(_context.Settings.AsQueryable(), page, pageSize));
        }
        public IActionResult Edit(int id)
        {
            var settings = _context.Settings.FirstOrDefault(x => x.Id == id);

            if (settings == null)
            {
                return NotFound();
            }

            return View(settings);
        }
        [HttpPost]
        public IActionResult Edit(Settings settings)
        {
            var oldsettings = _context.Settings.FirstOrDefault(x => x.Id == settings.Id);

            if (oldsettings == null)
            {
                return NotFound();
            }

            oldsettings.Value = settings.Value;

            _context.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
