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
    public class OrderController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly HnBandContext _context;

        public OrderController(UserManager<AppUser> userManager, HnBandContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        
        public IActionResult Checkout()
        {
            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            CheckoutViewModel checkoutVM = new CheckoutViewModel
            {
                Orders = _getBasket(member),
                Order = new Order
                {
                    Email = member?.Email,
                    PhoneNumber = member?.PhoneNumber,
                    FullName = member?.FullName,
                    Address = member?.Address,
                    City = member?.City,
                    Country = member?.Country
                }
            };
            return View(checkoutVM);


            
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
