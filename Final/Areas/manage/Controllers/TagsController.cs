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
    public class TagsController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;
        public TagsController(HnBandContext context, IWebHostEnvironment env)
        {

            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            string pageSizestr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;

            int pageSize = string.IsNullOrWhiteSpace(pageSizestr) ? 3 : int.Parse(pageSizestr);

            return View(PaginatedList<Tags>.Create(_context.Tags.AsQueryable(), page, pageSize));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tags tags)
        {

            if (!ModelState.IsValid)
                return View();

            _context.Tags.Add(tags);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var tags = _context.Tags.FirstOrDefault(x => x.Id == id);

            if (tags == null)
            {
                return NotFound();
            }

            return View(tags);
        }
        [HttpPost]
        public IActionResult Edit(Tags tags)
        {
            var oldgtags = _context.Tags.FirstOrDefault(x => x.Id == tags.Id);

            if (oldgtags == null)
            {
                return NotFound();
            }
            oldgtags.Name = oldgtags.Name;
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Tags tags = _context.Tags.FirstOrDefault(x => x.Id == id);

            return View(tags);
        }

        [HttpPost]
        public IActionResult Delete(Tags tags)
        {
            Tags existtags = _context.Tags.FirstOrDefault(x => x.Id == tags.Id);

            if (existtags == null)
                return NotFound();

            _context.Tags.Remove(existtags);

            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
    
}
