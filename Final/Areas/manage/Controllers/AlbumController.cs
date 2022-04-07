using Final.Helpers;
using Final.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.Controllers
{
    [Area("manage")]
    public class AlbumController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;
        public AlbumController(HnBandContext contex, IWebHostEnvironment env)
        {
            _context = contex;
            _env = env;
        }
        public IActionResult Index(int page = 1, bool? isDeleted = null)
        {
            ViewBag.IsDeleted = isDeleted;

            var products = _context.Albums.Include(x => x.Singer).Include(x => x.AlbumTracks)
                .Include(x => x.Genres).AsQueryable();

            if (isDeleted != null)
                products = products.Where(x => x.IsDeleted == isDeleted);

            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = pageSizeStr == null ? 3 : int.Parse(pageSizeStr);
            return View(PaginatedList<Album>.Create(products, page, pageSize));


        }
        public IActionResult Create()
        {
            ViewBag.Genres = _context.Genres.ToList();
            ViewBag.Singers = _context.Singers.Where(x => !x.IsDeleted).ToList();

       

            return View();
        }
        [HttpPost]
        public IActionResult Create(Album album)
        {
            ViewBag.Genres = _context.Genres.ToList();
            ViewBag.Singers = _context.Singers.Where(x => !x.IsDeleted).ToList();


            if (!ModelState.IsValid)
                return View();

            if (album.AlbumImage == null)
            {
                ModelState.AddModelError("PosterFile", "PosterFile is required");
                return View();
            }
            else
            {
                if (album.AlbumImage.ContentType != "image/jpeg" && album.AlbumImage.ContentType != "image/png")
                {
                    ModelState.AddModelError("PosterFile", "file type must be image/jpeg or image/png");
                    return View();
                }

                if (album.AlbumImage.Length > 4194304)
                {
                    ModelState.AddModelError("PosterFile", "file size must be less than 4 mb");
                    return View();
                }
            }
            album.Image = Guid.NewGuid().ToString() + album.AlbumImage.FileName;

            string path = Path.Combine(_env.WebRootPath, "uploads/albums", album.Image);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                album.AlbumImage.CopyTo(stream);
            }

            if (!_context.Genres.Any(x => x.Id == album.GenreId))
            {
                ModelState.AddModelError("Genres", "Genres not found");
                return View();
            }
            if (!_context.Singers.Any(x => x.Id == album.SingerId && !x.IsDeleted))
            {
                ModelState.AddModelError("Singers", "Singers not found");
                return View();
            }

            _context.Albums.Add(album);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            Album albums = _context.Albums.Include(x => x.Singer).Include(x => x.Genres).Include(x => x.AlbumTracks).FirstOrDefault(x => x.Id == id);

            ViewBag.Genres = _context.Genres.ToList();
            ViewBag.Tracks = _context.Tracks.Include(x=>x.Album).ToList();
            ViewBag.Singers = _context.Singers.Where(x => !x.IsDeleted).ToList();

            if (albums is null) return View("_ErrorPartialView");


            return View(albums);

        }
        [HttpPost]
        public IActionResult Edit(Album album)
        {
            Album existalbum = _context.Albums.Include(x => x.Singer).Include(x => x.Genres).Include(x => x.AlbumTracks).FirstOrDefault(x => x.Id == album.Id);
                
            ViewBag.Genres = _context.Genres.ToList();
            ViewBag.Tracks = _context.Tracks.Include(x => x.Album).ToList();
            ViewBag.Singers = _context.Singers.Where(x => !x.IsDeleted).ToList();

            if (existalbum == null)
                return NotFound();

            if (!_context.Genres.Any(x => x.Id == album.GenreId))
            {
                ModelState.AddModelError("GenreId", "Genre not found");
                return View();
            }
            if (!_context.Singers.Any(x => x.Id == album.SingerId && !x.IsDeleted))
            {
                ModelState.AddModelError("SingerId", "Singer not found");
                return View();
            }
            album.Image = Guid.NewGuid().ToString() + album.AlbumImage.FileName;

            string path = Path.Combine(_env.WebRootPath, "uploads/albums", album.Image);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                album.AlbumImage.CopyTo(stream);
            }

            existalbum.Image = album.Image;
          
            existalbum.SingerId = album.SingerId;
            existalbum.GenreId = album.GenreId;
            existalbum.AlbumTracks = album.AlbumTracks;
            existalbum.Name = album.Name;
            existalbum.Desc = album.Desc;
            existalbum.ModifiedAt = DateTime.UtcNow.AddHours(4);


            _context.SaveChanges();


            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            Album album = _context.Albums.FirstOrDefault(x => x.Id == id);

            return View(album);
        }

        [HttpPost]
        public IActionResult Delete(Singer singer)
        {
            Album existAlbum = _context.Albums.FirstOrDefault(x => x.Id == singer.Id);

            if (existAlbum == null)
                return NotFound();

            _context.Albums.Remove(existAlbum);

            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
