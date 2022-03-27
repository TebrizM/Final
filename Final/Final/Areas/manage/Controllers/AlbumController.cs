using Final.Helpers;
using Final.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

            var products = _context.Albums.Include(x => x.Singer).Include(x => x.Tracks).Include(x => x.AlbumImages)
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
            ViewBag.Brands = _context.Singers.Where(x => !x.IsDeleted).ToList();
            ViewBag.Types = _context.Tracks.ToList();
       

            return View();
        }
        [HttpPost]
        public IActionResult Create(Album album)
        {
            ViewBag.Genres = _context.Genres.ToList();
            ViewBag.Brands = _context.Singers.Where(x => !x.IsDeleted).ToList();
            ViewBag.Types = _context.Tracks.ToList();

            if (!ModelState.IsValid)
                return View();

            if (album.PosterFile == null)
            {
                ModelState.AddModelError("PosterFile", "PosterFile is required");
                return View();
            }
            else
            {
                if (album.PosterFile.ContentType != "image/jpeg" && album.PosterFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("PosterFile", "file type must be image/jpeg or image/png");
                    return View();
                }

                if (album.PosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("PosterFile", "file size must be less than 2mb");
                    return View();
                }
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

            album.AlbumImages = new List<AlbumImage>();
           
            AlbumImage posterImage = new AlbumImage
            {
                AlbumStatus = true,
                Image = FileManager.Save(_env.WebRootPath, "uploads/albums", album.PosterFile)
            };
            album.AlbumImages.Add(posterImage);

            _context.Albums.Add(album);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            Album albums = _context.Albums.Include(x => x.Singer).Include(x => x.Genres).Include(x => x.Tracks).Include(x => x.AlbumImages).FirstOrDefault(x => x.Id == id);

            if (albums is null) return View("_ErrorPartialView");

            ViewBag.Genres = _context.Genres.ToList();
            ViewBag.Brands = _context.Singers.Where(x => !x.IsDeleted).ToList();
            ViewBag.Types = _context.Tracks.ToList();


            return View(albums);

        }
        [HttpPost]
        public IActionResult Edit(Album album)
        {
            Album existalbum = _context.Albums.Include(x => x.Singer).Include(x => x.Genres).Include(x => x.Tracks).Include(x => x.AlbumImages).FirstOrDefault(x => x.Id == album.Id);

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


            if (album.PosterFile != null && album.PosterFile.ContentType != "image/jpeg" && album.PosterFile.ContentType != "image/png")
            {
                ModelState.AddModelError("PosterFile", "file type must be image/jpeg or image/png");
                return View();
            }

            if (album.PosterFile != null && album.PosterFile.Length > 2097152)
            {
                ModelState.AddModelError("PosterFile", "file size must be less than 2mb");
                return View();
            }

            AlbumImage poster = existalbum.AlbumImages.FirstOrDefault(x => x.AlbumStatus == true);

            if (album.PosterFile != null)
            {
                string newPoster = FileManager.Save(_env.WebRootPath, "uploads/albums", album.PosterFile);
                if (poster != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/books", existalbum.AlbumImages.FirstOrDefault(x => x.AlbumStatus == true).Image);
                    poster.Image = newPoster;
                }
                else
                {
                    poster = new AlbumImage { Image = newPoster, AlbumStatus = true };
                    existalbum.AlbumImages.Add(poster);

                }

            }


            existalbum.AlbumImages.RemoveAll(x => x.AlbumStatus == null);

            existalbum.SingerId = album.SingerId;
            existalbum.GenreId = album.GenreId;
            existalbum.Tracks = album.Tracks;
            existalbum.Name = album.Name;
            existalbum.ModifiedAt = DateTime.UtcNow.AddHours(4);


            _context.SaveChanges();


            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {

            Album existAlbum = _context.Albums.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
            if (existAlbum == null) return View("Error");
            existAlbum.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult Restore(int id)
        {
            Album existAlbum = _context.Albums.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
            if (existAlbum == null) return View("Error");
            existAlbum.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
