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
    public class SliderController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(HnBandContext context, IWebHostEnvironment env)
        {

            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            string pageSizestr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;

            int pageSize = string.IsNullOrWhiteSpace(pageSizestr) ? 3 : int.Parse(pageSizestr);

            return View(PaginatedList<Slider>.Create(_context.Sliders.AsQueryable(), page, pageSize));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {

            if (!ModelState.IsValid)
                return View();

            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }
        [HttpPost]
        public IActionResult Edit(Slider Slider)
        {
            var oldSlider = _context.Sliders.FirstOrDefault(x => x.Id == Slider.Id);

            if (oldSlider == null)
            {
                return NotFound();
            }

          


            oldSlider.Order = Slider.Order;
            oldSlider.Title1 = Slider.Title1;
            oldSlider.Title2 = Slider.Title2;
            oldSlider.BtnText = Slider.BtnText;
            oldSlider.BtnUrl = Slider.BtnUrl;
            oldSlider.Desc = Slider.Desc;
            _context.SaveChanges();


            return RedirectToAction("Index");
        }


        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Sliders.Remove(slider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
