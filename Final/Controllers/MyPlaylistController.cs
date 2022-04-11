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
            MyPlaylistViewModel playlistVM = new MyPlaylistViewModel
            {


                Track = _context.Tracks.ToList(),
                Genres = _context.Genres.Include(x => x.Albums).ToList(),
                Singers = _context.Singers.Include(x=>x.Albums).Include(x=>x.Tracks).ToList(),
                Albums = _context.Albums.Include(x=>x.AlbumTracks).Include(x=>x.Singer).Include(x=>x.Genres).ToList()


            };

            return View(playlistVM);
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
                string productIdsStr = HttpContext.Request.Cookies["playlist"];
                List<TrackItemViewModel> items = new List<TrackItemViewModel>();

                if (!string.IsNullOrWhiteSpace(productIdsStr))
                {
                    items = JsonConvert.DeserializeObject<List<TrackItemViewModel>>(productIdsStr);

                }
                TrackItemViewModel item = items.FirstOrDefault(x => x.TrackId == id);

                if (item == null)
                {
                    item = new TrackItemViewModel { TrackId = id, Count = 1 };
                    items.Add(item);

                }
                else
                {
                    item.Count++;
                }

                productIdsStr = JsonConvert.SerializeObject(items);

                HttpContext.Response.Cookies.Append("playlist", productIdsStr);
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
                else
                {
                    item.Count++;
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

        //public IActionResult RemoveOrder(int id)
        //{
        //    if (!_context.Tours.Any(x => x.Id == id))
        //    {
        //        return RedirectToAction("error", "home");
        //    }

        //    AppUser appUser = null;

        //    if (User.Identity.IsAuthenticated)
        //    {
        //        appUser = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
        //    }

        //    if (appUser == null)
        //    {
        //        string cookie = HttpContext.Request.Cookies["playlist"];
        //        List<TourItemViewModel> cookieItems = new List<TourItemViewModel>();

        //        if (!string.IsNullOrWhiteSpace(cookie))
        //        {
        //            cookieItems = JsonConvert.DeserializeObject<List<TourItemViewModel>>(cookie);
        //        }

        //        TourItemViewModel cookieItem = cookieItems.FirstOrDefault(x => x.TourId == id);


        //        if (cookieItem.Count > 1)
        //        {
        //            cookieItem.Count--;
        //        }
        //        else
        //        {
        //            cookieItems.Remove(cookieItem);
        //        }

        //        cookie = JsonConvert.SerializeObject(cookieItems);
        //        HttpContext.Response.Cookies.Append("playlist", cookie);


        //        return RedirectToAction("index", _getTrack(cookieItems));
        //    }
        //    else
        //    {
        //        TourOrderItem item = _context.TourOrderItems.FirstOrDefault(x => x.AppUserId == appUser.Id && x.ToursId == id);

        //        if (item.Count > 1)
        //        {
        //            item.Count--;
        //        }
        //        else
        //        {
        //            _context.TourOrderItems.Remove(item);
        //        }
        //        _context.SaveChanges();

        //        var items = _context.TrackPlaylistItems.Where(x => x.AppUserId == appUser.Id).ToList();
        //        return RedirectToAction("index", _getTrack(items));
        //    }

        //}
    }
}
