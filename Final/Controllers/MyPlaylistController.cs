using Final.Models;
using Final.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class MyPlaylistController : Controller
    {
        private readonly HnBandContext _context;
        private readonly UserManager<AppUser> _userManager;
        public MyPlaylistController(HnBandContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index( int? genreId, int? singerId,  int page = 1)
        {
            TempData["Playlist"] = "active-nav-btn";
            var albums = _context.Albums.Where(x => !x.IsDeleted);


            ViewBag.GenreId = genreId;
            ViewBag.SingerId = singerId;

      
            if (genreId > 3 || genreId < 0)
            {
                return RedirectToAction("error", "home");
            }
            if (genreId != null)
            {
                albums = albums.Where(x => x.GenreId == genreId);
            }
            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            MyPlaylistViewModel playlistVM = new MyPlaylistViewModel
            {

                Tracks = _getTracks(member),
                Genres = _context.Genres.Include(x => x.Albums).ToList(),
                Singers = _context.Singers.Include(x=>x.Albums).Include(x=>x.Tracks).ToList(),
                Albums = _context.Albums.Include(x=>x.AlbumTracks).Include(x=>x.Singer).Include(x=>x.Genres).ToList()


            };

            return View(playlistVM);
        }


        private TrackViewModel _getTracks(AppUser member)
        {
            TrackViewModel ListVM = new TrackViewModel
            {
                PlaylistItems = new List<PlaylistViewModel>()
            };

            List<TrackItemViewModel> items = new List<TrackItemViewModel>();

            if (member == null)
            {
                string ItemsStr = HttpContext.Request.Cookies["playlist"];

                if (!string.IsNullOrWhiteSpace(ItemsStr))
                    items = JsonConvert.DeserializeObject<List<TrackItemViewModel>>(ItemsStr);
            }
            else
            {
                items = _context.TrackPlaylistItems.Where(x => x.AppUserId == member.Id).Select(b => new TrackItemViewModel { TrackId = b.AlbumTrackId, Count = b.Count }).ToList();
            }

            foreach (var item in items)
            {
                AlbumTrack track = _context.Tracks.FirstOrDefault(x => x.Id == item.TrackId);
                PlaylistViewModel listItem = new PlaylistViewModel
                {
                    Track = track,
                    Count = item.Count
                };



                ListVM.PlaylistItems.Add(listItem);
            }

            return ListVM;
        }
    }
}
