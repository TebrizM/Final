using Final.Models;
using Final.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class AlbumController : Controller
    {
        private readonly HnBandContext _context;
        public AlbumController(HnBandContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.PageIndex = page;

            var albums = _context.Albums.Include(x => x.AlbumTracks).Include(x => x.Singer).Skip((page - 1) * 6).Take(6).ToList();
            AlbumViewModel albumVM = new AlbumViewModel
            {
                AlbumTracks = _context.Tracks.ToList(),
                Albums = albums
            };
            ViewBag.TotalPages = (int)Math.Ceiling(albums.Count() / 6d);

            return View(albumVM);
        }

        public IActionResult Detail(int Id)
        {
            Album album = _context.Albums.Include(x => x.AlbumTracks).Include(x => x.Singer).FirstOrDefault(x => x.Id == Id && !x.IsDeleted);

            AlbumDetailViewModel albumdetailVM = new AlbumDetailViewModel
            {
                Albums = album,
                Tracks = _context.Tracks.ToList()
            };


            return View(albumdetailVM);
        }
    }
}
