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
    public class GenreController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;
        public GenreController(HnBandContext context, IWebHostEnvironment env)
        {

            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            string pageSizestr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;

            int pageSize = string.IsNullOrWhiteSpace(pageSizestr) ? 3 : int.Parse(pageSizestr);

            return View(PaginatedList<Genre>.Create(_context.Genres.AsQueryable(), page, pageSize));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genres)
        {

            if (!ModelState.IsValid)
                return View();

            _context.Genres.Add(genres);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var tours = _context.Genres.FirstOrDefault(x => x.Id == id);

            if (tours == null)
            {
                return NotFound();
            }

            return View(tours);
        }
        [HttpPost]
        public IActionResult Edit(Genre genres)
        {
            var oldgenres = _context.Genres.FirstOrDefault(x => x.Id == genres.Id);

            if (oldgenres == null)
            {
                return NotFound();
            }




            oldgenres.Name = genres.Name;
            oldgenres.Tracks = genres.Tracks;
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        //DELETE ACTION
        public IActionResult Delete(int id)
        {
            Genre existGenre = _context.Genres.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existGenre == null)
                return NotFound();

            //ViewBag.Genres = _context.Genres.Where(x => !x.IsDeleted).Where(x => x.LiquorFlavorId == id).ToList();

            //foreach (var product in ViewBag.Products)
            //{
            //    product.IsDeleted = true;
            //}

            existGenre.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        //RESTORE ACTION
        public IActionResult Restore(int id)
        {
            Genre existGenre = _context.Genres.FirstOrDefault(x => x.Id == id && x.IsDeleted);

            if (existGenre == null)
                return NotFound();

            //ViewBag.Products = _context.Products.Where(x => x.IsDeleted).Where(x => x.LiquorFlavorId == id).ToList();

            //foreach (var product in ViewBag.Products)
            //{
            //    product.IsDeleted = false;
            //}

            existGenre.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
