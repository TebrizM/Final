using Final.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.Controllers
{
    [Area("manage")]

    public class TrackController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;
        public TrackController(HnBandContext context, IWebHostEnvironment env)
        {

            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            string pageSizestr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;

            int pageSize = string.IsNullOrWhiteSpace(pageSizestr) ? 3 : int.Parse(pageSizestr);

            return View(PaginatedList<AlbumTrack>.Create(_context.Tracks.AsQueryable(), page, pageSize));
        }
        public IActionResult Create()
        {

            ViewBag.Albums = _context.Albums.ToList();


            return View();
        }
        [HttpPost]
        public IActionResult Create(AlbumTrack track)
        {
            ViewBag.Albums = _context.Albums.ToList();


            if (!ModelState.IsValid)
                return View();

            if (track.TrackSource == null)
            {
                ModelState.AddModelError("TrackSource", "TrackSource is required");
                return View();
            }


            if (!_context.Albums.Any(x => x.Id == track.AlbumId && !x.IsDeleted))
            {
                ModelState.AddModelError("Albums", "Albums not found");
                return View();
            }


            track.GeneratedSource = Guid.NewGuid().ToString() + track.TrackSource.FileName;

            string path = Path.Combine(_env.WebRootPath, "uploads/tracks", track.GeneratedSource);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                track.TrackSource.CopyTo(stream);
            }


            _context.Tracks.Add(track);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            AlbumTrack track = _context.Tracks.FirstOrDefault(x => x.Id == id);

            return View(track);
        }

        [HttpPost]
        public IActionResult Delete(Singer singer)
        {
            AlbumTrack existtrack = _context.Tracks.FirstOrDefault(x => x.Id == singer.Id);

            if (existtrack == null)
                return NotFound();

            _context.Tracks.Remove(existtrack);

            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
