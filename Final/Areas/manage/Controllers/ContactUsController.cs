using Final.Models;
using Final.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class ContactUsController : Controller
    {
        private readonly HnBandContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IWebHostEnvironment _env;

        public ContactUsController(HnBandContext context, UserManager<AppUser> userManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
           _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            string pageSizestr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;

            int pageSize = string.IsNullOrWhiteSpace(pageSizestr) ? 3 : int.Parse(pageSizestr);

            return View(PaginatedList<Contact>.Create(_context.Contacts.AsQueryable(), page, pageSize));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var feedBack = await _context.Contacts.FirstOrDefaultAsync(x=>x.Id == id);
            if (feedBack.IsDeleted)
            {
                TempData["Error"] = "You answered the question";
                return RedirectToAction("Index");
            }
            if(feedBack == null)
            {
                return RedirectToAction("error", "home");
            }

            return View(feedBack);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Contact feedBackPost)
        {
            var feedBack = await _context.Contacts.FirstOrDefaultAsync(x=>x.Id == feedBackPost.Id);

            if (feedBack.Name != feedBackPost.Name || feedBack.Email != feedBackPost.Email || feedBack.Text != feedBackPost.Text)
            {
                return RedirectToAction("error", "home");
            }

            if (String.IsNullOrWhiteSpace(feedBackPost.Answer))
            {
                ModelState.AddModelError("Answer", "You Didn't Send Answer!");
                return View();
            }

            feedBack.Answer = feedBackPost.Answer;
            feedBack.IsDeleted = true;
            await _context.SaveChangesAsync();

            var path = _env.WebRootPath + Path.DirectorySeparatorChar.ToString() + "assets" + Path.DirectorySeparatorChar.ToString() + "templates" + Path.DirectorySeparatorChar.ToString() + "ContactUs.html";

            Dictionary<string, string> replaces = new Dictionary<string, string>();
            replaces.Add("{question}", feedBack.Text);
            replaces.Add("{answer}", feedBack.Answer);
            replaces.Add("{root}", _env.WebRootPath.ToString());
            await EmailUtil.SendEmailAsync(feedBack.Email, "Cavab", path, replaces);
            return RedirectToAction("Index");
        }
    }
}
