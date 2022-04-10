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
       
        private OrderViewModel _getBasket(AppUser member)
        {
            OrderViewModel basketVM = new OrderViewModel
            {
                OrderItems = new List<OrderItemViewModel>()
            };

            List<TourItemViewModel> items = new List<TourItemViewModel>();

            if (member == null)
            {
                string basketItemsStr = HttpContext.Request.Cookies["basket"];

                if (!string.IsNullOrWhiteSpace(basketItemsStr))
                    items = JsonConvert.DeserializeObject<List<TourItemViewModel>>(basketItemsStr);
            }
            else
            {
                items = _context.TourOrderItems.Where(x => x.AppUserId == member.Id).Select(b => new TourItemViewModel { TourId = b.ToursId, Count = b.Count }).ToList();
            }

            foreach (var item in items)
            {
                Tours tours = _context.Tours.FirstOrDefault(x => x.Id == item.TourId);
                OrderItemViewModel productItem = new OrderItemViewModel
                {
                    Tours = tours,
                    Count = item.Count
                };

                decimal totalPrice = tours.DiscountPercent > 0 ? (tours.SalePrice * (1 - tours.DiscountPercent / 100)) : tours.SalePrice;
                basketVM.TotalPrice += totalPrice * item.Count;

                basketVM.OrderItems.Add(productItem);
            }

            return basketVM;
        }


        [HttpPost]
        public IActionResult Create(Order order)
        {
            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            CheckoutViewModel checkoutVM = new CheckoutViewModel
            {
                Orders = _getBasket(member),
                Order = order
            };

            if (!ModelState.IsValid)
                return View("Checkout", checkoutVM);

            if (checkoutVM.Orders.OrderItems.Count == 0)
            {
                ModelState.AddModelError("", "You must chose any product!");
                return View("Checkout", checkoutVM);
            }


            order.AppUserId = member?.Id;
            order.CreatedAt = DateTime.UtcNow.AddHours(4);
            order.ModifiedAt = DateTime.UtcNow.AddHours(4);
            order.Status = Enums.OrderStatus.Pending;

            order.OrderItems = new List<OrderItem>();

            foreach (var item in checkoutVM.Orders.OrderItems)
            {
                OrderItem orderItem = new OrderItem
                {
                    Tours = item.Tours,
                    SalePrice = item.Tours.SalePrice,
                    CostPrice = item.Tours.CostPrice,
                    DiscountPrice = item.Tours.DiscountPercent > 0 ? (item.Tours.SalePrice * (1 - item.Tours.DiscountPercent / 100)) : item.Tours.SalePrice,
                    Count = item.Count
                };

                order.OrderItems.Add(orderItem);
                order.TotalPrice += orderItem.DiscountPrice * orderItem.Count;
            }

            _context.Orders.Add(order);

            if (member == null)
                HttpContext.Response.Cookies.Delete("basket");
            else
                _context.TourOrderItems.RemoveRange(_context.TourOrderItems.Where(x => x.AppUserId == member.Id));

            _context.SaveChanges();



            return RedirectToAction("profile", "account");
        }

    }
}
