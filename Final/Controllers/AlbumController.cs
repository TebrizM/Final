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
    public class AlbumController : Controller
    {
        private readonly HnBandContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AlbumController(HnBandContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index(int page = 1)
        {
            TempData["Album"] = "active-nav-btn";
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
       

            AlbumDetailViewModel albumdetailVM = new AlbumDetailViewModel
            {
                Albums = _context.Albums.Include(x => x.AlbumTracks).Include(x => x.Singer).FirstOrDefault(x => x.Id == Id && !x.IsDeleted),
                 Tracks = _context.Tracks.ToList()

            };


            return View(albumdetailVM);
        }


        public IActionResult AddTrack(int id)
        {
            if (!_context.Tracks.Any(x => x.Id == id))
                return NotFound();

            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            if (member == null)
            {
                string trackIdsStr = HttpContext.Request.Cookies["playlist"];
                List<TrackItemViewModel> items = new List<TrackItemViewModel>();

                if (!string.IsNullOrWhiteSpace(trackIdsStr))
                {
                    items = JsonConvert.DeserializeObject<List<TrackItemViewModel>>(trackIdsStr);

                }
                TrackItemViewModel item = items.FirstOrDefault(x => x.TrackId == id);

                if (item == null)
                {
                    item = new TrackItemViewModel { TrackId = id, Count = 1 };
                    items.Add(item);

                }
                trackIdsStr = JsonConvert.SerializeObject(items);

                HttpContext.Response.Cookies.Append("playlist", trackIdsStr);
                return RedirectToAction("index", _getTrack(items));
            }
            else
            {
                TrackPlaylistItem item = _context.TrackPlaylistItems.FirstOrDefault(x => x.AppUserId == member.Id && x.AlbumTrackId == id);

                if (item == null)
                {
                    item = new TrackPlaylistItem
                    {
                        AppUserId = member.Id,
                        AlbumTrackId = id,
                        CreatedAt = DateTime.UtcNow.AddHours(4),
                        Count = 1
                    };
                    _context.TrackPlaylistItems.Add(item);
                }

                _context.SaveChanges();
                var items = _context.TrackPlaylistItems.Where(x => x.AppUserId == member.Id).ToList();
                return RedirectToAction("index", _getTrack(items));
            }
        }



        private TrackViewModel _getTrack(List<TrackItemViewModel> playlistItem)
        {
            TrackViewModel playlistVM = new TrackViewModel
            {
                PlaylistItems = new List<PlaylistViewModel>(),

            };

            foreach (var item in playlistItem)
            {
                AlbumTrack track = _context.Tracks.FirstOrDefault(x => x.Id == item.TrackId);
                PlaylistViewModel productBasketItem = new PlaylistViewModel
                {
                    Track = track,
                    Count = item.Count
                };

                playlistVM.PlaylistItems.Add(productBasketItem);

            }

            return playlistVM;
        }

        private TrackViewModel _getTrack(List<TrackPlaylistItem> basketItems)
        {
            TrackViewModel basketVM = new TrackViewModel
            {
                PlaylistItems = new List<PlaylistViewModel>(),

            };

            foreach (var item in basketItems)
            {
                AlbumTrack track = _context.Tracks.FirstOrDefault(x => x.Id == item.AlbumTrackId);
                PlaylistViewModel productBasketItem = new PlaylistViewModel
                {
                    Track = track,
                    Count = item.Count
                };

                basketVM.PlaylistItems.Add(productBasketItem);


            }

            return basketVM;
        }

        public IActionResult RemoveTrack(int id)
        {
            if (!_context.Tracks.Any(x => x.Id == id))
            {
                return RedirectToAction("error", "home");
            }

            AppUser appUser = null;

            if (User.Identity.IsAuthenticated)
            {
                appUser = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            if (appUser == null)
            {
                string cookie = HttpContext.Request.Cookies["playlist"];
                List<TrackItemViewModel> cookieItems = new List<TrackItemViewModel>();

                if (!string.IsNullOrWhiteSpace(cookie))
                {
                    cookieItems = JsonConvert.DeserializeObject<List<TrackItemViewModel>>(cookie);
                }

                TrackItemViewModel cookieItem = cookieItems.FirstOrDefault(x => x.TrackId == id);

                if(cookieItems != null)
                {
                    cookieItems.Remove(cookieItem);

                }
                else
                {
                    return View("error", "home");
                }
                cookie = JsonConvert.SerializeObject(cookieItems);
                HttpContext.Response.Cookies.Append("playlist", cookie);


                return RedirectToAction("index", _getTrack(cookieItems));
            }
            else
            {
                TrackPlaylistItem item = _context.TrackPlaylistItems.FirstOrDefault(x => x.AppUserId == appUser.Id && x.AlbumTrackId == id);


                if (item != null)
                {
                    _context.TrackPlaylistItems.Remove(item);

                }
                else
                {
                    return View("error", "home");
                }


         
                
                _context.SaveChanges();

                var items = _context.TrackPlaylistItems.Where(x => x.AppUserId == appUser.Id).ToList();
                return RedirectToAction("index","myplaylist", _getTrack(items));
            }

        }

    }
}
