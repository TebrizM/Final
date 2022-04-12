using Final.Models;
using Final.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly HnBandContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ContactUsController(HnBandContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        
        }

        [HttpPost]
        public async Task<IActionResult> ContactUs(ContactUsViewModel contactUsViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser appUser = new AppUser();
            if (User.Identity.IsAuthenticated)
            {
                appUser = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            Contact feedBack = new Contact();
            if (appUser != null)
            {
                feedBack = new Contact
                {
                    AppUserId = appUser.Id,
                    CreatedAt = DateTime.UtcNow.AddHours(4),
                    ModifiedAt = DateTime.UtcNow.AddHours(4),
                    Name = contactUsViewModel.Name,
                    Email = contactUsViewModel.Email,
                    Text = contactUsViewModel.Text,
                    IsDeleted = false,
                };
                await _context.Contacts.AddAsync(feedBack);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            feedBack = new Contact
            {

                CreatedAt = DateTime.UtcNow.AddHours(4),
                ModifiedAt = DateTime.UtcNow.AddHours(4),
                Name = contactUsViewModel.Name,
                Email = contactUsViewModel.Email,
                Text = contactUsViewModel.Text,
                IsDeleted = false,
            };

            await _context.Contacts.AddAsync(feedBack);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
