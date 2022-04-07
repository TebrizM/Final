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
    public class SingerController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;
        public SingerController(HnBandContext context, IWebHostEnvironment env)
        {

            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            string pageSizestr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;

            int pageSize = string.IsNullOrWhiteSpace(pageSizestr) ? 3 : int.Parse(pageSizestr);

            return View(PaginatedList<Singer>.Create(_context.Singers.AsQueryable(), page, pageSize));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Singer singer)
        {

            if (!ModelState.IsValid)
                return View();

            _context.Singers.Add(singer);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var singer = _context.Singers.FirstOrDefault(x => x.Id == id);

            if (singer == null)
            {
                return NotFound();
            }

            return View(singer);
        }
        [HttpPost]
        public IActionResult Edit(Singer singer)
        {
            var oldsinger = _context.Singers.FirstOrDefault(x => x.Id == singer.Id);

            if (oldsinger == null)
            {
                return NotFound();
            }

            oldsinger.Name = singer.Name;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Singer singer = _context.Singers.FirstOrDefault(x => x.Id == id);

            return View(singer);
        }

        [HttpPost]
        public IActionResult Delete(Singer singer)
        {
            Singer existsinger = _context.Singers.FirstOrDefault(x => x.Id == singer.Id);

            if (existsinger == null)
                return NotFound();

            _context.Singers.Remove(existsinger);

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Restore(int id)
        {
            Singer existsinger = _context.Singers.FirstOrDefault(x => x.Id == id);

            if (existsinger == null)
                return NotFound();

            _context.Singers.Add(existsinger); 
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
