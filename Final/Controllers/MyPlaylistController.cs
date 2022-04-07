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
    public class MyPlaylistController : Controller
    {
        private readonly HnBandContext _context;
        public MyPlaylistController(HnBandContext context)
        {
            _context = context;
        }
        public IActionResult Index( int? genreId, int? singerId,  int page = 1)
        {
            var albums = _context.Albums.Where(x => !x.IsDeleted);


            ViewBag.GenreId = genreId;
            ViewBag.SingerId = singerId;

      
            if (genreId > 3 || genreId < 0)
            {
                return BadRequest();
            }
            if (genreId != null)
            {
                albums = albums.Where(x => x.GenreId == genreId);
            }
            MyPlaylistViewModel playlistVM = new MyPlaylistViewModel
            {

         
                AlbumTracks = _context.Tracks.ToList(),
                Genres = _context.Genres.Include(x => x.Albums).ToList(),
                Singers = _context.Singers.Include(x=>x.Albums).ToList(),
                Albums = _context.Albums.Include(x=>x.AlbumTracks).Include(x=>x.Singer).Include(x=>x.Genres).ToList()


            };

            return View(playlistVM);
        }
    }
}
