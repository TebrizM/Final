using Final.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
    }
}
