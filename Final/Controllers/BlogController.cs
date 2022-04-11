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
    public class BlogController : Controller
    {
        private readonly HnBandContext _context; 
        private readonly UserManager<AppUser> _userManager;
        public BlogController(HnBandContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index(int? tagId)
        {
            
            ViewBag.TagId = tagId;

            if (tagId > 3 || tagId < 0)
            {
                return RedirectToAction("error", "home");
            }
           
            BlogViewModel blogVM = new BlogViewModel
            {
                Blogs = _context.Blogs.ToList(),
                BlogTags = _context.BlogTags.ToList(),
                Tags = _context.Tags.ToList(),
    
            };
            return View(blogVM);
        }

        public IActionResult Detail(int Id)
        {
            Blog blogs = _context.Blogs.Include(x => x.BlogComments).ThenInclude(x => x.AppUser).FirstOrDefault(x => x.Id == Id && !x.IsDeleted);

            BlogDetailViewModel blogdetailVM = new BlogDetailViewModel
            {
            
                Blogs = blogs,
                BlogComments = new BlogComment { BlogId = Id }
               
            };

            return View(blogdetailVM);
        }
        [HttpPost]
        public IActionResult Comment(BlogComment comment)
        {
            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            if (member == null)
                return RedirectToAction("login", "account");

            Blog blogs = _context.Blogs.Include(x => x.BlogComments).ThenInclude(x => x.AppUser).FirstOrDefault(x => x.Id == comment.BlogId && !x.IsDeleted);

   

            if (blogs == null)
                return RedirectToAction("error", "home");

            if (!ModelState.IsValid)
            {


                BlogDetailViewModel productDetail = new BlogDetailViewModel
                {
                    Blogs = blogs,
                    BlogComments = comment,
                   
                };

                return View("Detail", productDetail);
            }
            comment.AppUserId = member.Id;
            comment.CreatedAt = DateTime.UtcNow.AddHours(4);
            blogs.BlogComments.Add(comment);
            _context.SaveChanges();

            return RedirectToAction("Detail", new { id = comment.BlogId });
        }
    }
}
