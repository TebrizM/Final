using Final.Models;
using Final.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class ToursController : Controller
    {
        private readonly HnBandContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ToursController(HnBandContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {

            ToursViewModel tourVM = new ToursViewModel
            {
                Tours = _context.Tours.ToList()
            };

            return View(tourVM);
        }

        public IActionResult AddOrder(int id)
        {
            if (!_context.Tours.Any(x => x.Id == id))
                return NotFound();

            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            if (member == null)
            {
                string productIdsStr = HttpContext.Request.Cookies["basket"];
                List<TourItemViewModel> items = new List<TourItemViewModel>();

                if (!string.IsNullOrWhiteSpace(productIdsStr))
                {
                    items = JsonConvert.DeserializeObject<List<TourItemViewModel>>(productIdsStr);

                }
                TourItemViewModel item = items.FirstOrDefault(x => x.TourId == id);

                if (item == null)
                {
                    item = new TourItemViewModel { TourId = id, Count = 1 };
                    items.Add(item);

                }
                else
                {
                    item.Count++;
                }

                productIdsStr = JsonConvert.SerializeObject(items);

                HttpContext.Response.Cookies.Append("basket", productIdsStr);
                return RedirectToAction("index", _getOrder(items));
            }
            else
            {
                TourOrderItem item = _context.TourOrderItems.FirstOrDefault(x => x.AppUserId == member.Id && x.ToursId == id);

                if (item == null)
                {
                    item = new TourOrderItem
                    {
                        AppUserId = member.Id,
                        ToursId = id,
                        CreatedAt = DateTime.UtcNow.AddHours(4),
                        Count = 1
                    };
                    _context.TourOrderItems.Add(item);
                }
                else
                {
                    item.Count++;
                }
                _context.SaveChanges();
                var items = _context.TourOrderItems.Where(x => x.AppUserId == member.Id).ToList();
                return RedirectToAction("index", _getOrder(items));
            }
        }


        private OrderViewModel _getOrder(List<TourItemViewModel> basketItems)
        {
            OrderViewModel basketVM = new OrderViewModel
            {
                OrderItems = new List<OrderItemViewModel>(),
                TotalPrice = 0  
            };

            foreach (var item in basketItems)
            {
                Tours tours = _context.Tours.FirstOrDefault(x => x.Id == item.TourId);
                OrderItemViewModel productBasketItem = new OrderItemViewModel
                {
                    Tours = tours,
                    Count = item.Count
                };

                basketVM.OrderItems.Add(productBasketItem);
                decimal totalPrice = tours.DiscountPercent > 0 ? (tours.SalePrice * (1 - tours.DiscountPercent / 100)) : tours.SalePrice;
                basketVM.TotalPrice += totalPrice * item.Count;

            }

            return basketVM;
        }

        private OrderViewModel _getOrder(List<TourOrderItem> basketItems)
        {
            OrderViewModel basketVM = new OrderViewModel
            {
                OrderItems = new List<OrderItemViewModel>(),
                TotalPrice = 0
            };

            foreach (var item in basketItems)
            {
                Tours tours = _context.Tours.FirstOrDefault(x => x.Id == item.ToursId);
                OrderItemViewModel productBasketItem = new OrderItemViewModel
                {
                    Tours = tours,
                    Count = item.Count
                };

                basketVM.OrderItems.Add(productBasketItem);
                decimal totalPrice = tours.DiscountPercent > 0 ? (tours.SalePrice * (1 - tours.DiscountPercent / 100)) : tours.SalePrice;
                basketVM.TotalPrice += totalPrice * item.Count;

            }

            return basketVM;
        }
    }
}
