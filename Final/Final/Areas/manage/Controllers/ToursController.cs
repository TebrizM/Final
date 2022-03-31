using Final.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.Controllers
{
    [Area("manage")]
    public class ToursController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;
        public ToursController(HnBandContext context, IWebHostEnvironment env)
        {

            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            string pageSizestr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;

            int pageSize = string.IsNullOrWhiteSpace(pageSizestr) ? 3 : int.Parse(pageSizestr);

            return View(PaginatedList<Tours>.Create(_context.Tours.AsQueryable(), page, pageSize));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tours tours)
        {

            if (!ModelState.IsValid)
                return View();

            _context.Tours.Add(tours);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var tours = _context.Tours.FirstOrDefault(x => x.Id == id);

            if (tours == null)
            {
                return NotFound();
            }

            return View(tours);
        }
        [HttpPost]
        public IActionResult Edit(Tours tours)
        {
            var oldtours = _context.Tours.FirstOrDefault(x => x.Id == tours.Id);

            if (oldtours == null)
            {
                return NotFound();
            }




            oldtours.Date = tours.Date;
            oldtours.BtnText = tours.BtnText;
            oldtours.Info = tours.Info;
            oldtours.IsAvaiable = tours.IsAvaiable;
            oldtours.Location = tours.Location;
            oldtours.CostPrice = tours.CostPrice;
            oldtours.SalePrice = tours.SalePrice;
            oldtours.DiscountPercent = tours.DiscountPercent;
            _context.SaveChanges();


            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            Tours tours = _context.Tours.FirstOrDefault(x => x.Id == id);

            return View(tours);
        }

        [HttpPost]
        public IActionResult Delete(Tours tours)
        {
            Tours existtours = _context.Tours.FirstOrDefault(x => x.Id == tours.Id);

            if (existtours == null)
                return NotFound();

            _context.Tours.Remove(existtours);
            //existAuthor.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        //public IActionResult Restore(int id)
        //{
        //    Author existAuthor = _context.Authors.FirstOrDefault(x => x.Id == id && x.IsDeleted);

        //    if (existAuthor == null)
        //        return NotFound();

        //    existAuthor.IsDeleted = false;
        //    _context.SaveChanges();

        //    return RedirectToAction("index");
        //}

    }
}
