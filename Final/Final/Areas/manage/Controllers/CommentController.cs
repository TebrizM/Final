using Final.Models;
using Final.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.Controllers
{
    [Area("manage")]
    public class CommentController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;

        public CommentController(HnBandContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        #region Index

        public IActionResult Index(int page = 1)
        {
            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = string.IsNullOrWhiteSpace(pageSizeStr) ? 5 : int.Parse(pageSizeStr);
            return View(PaginatedList<BlogComment>.Create(_context.BlogComments.AsQueryable(), page, pageSize));
        }

        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            BlogComment comment = _context.BlogComments.FirstOrDefault(x => x.Id == id);
            if (comment is null) return View("Error", "home");
            return View(comment);
        }

        [HttpPost]
        public IActionResult Delete(DeleteEntityViewModel model)
        {

            if (!ModelState.IsValid) return View("Error", "home");

            var comment = _context.BlogComments.FirstOrDefault(x => x.Id == model.Id);

            if (comment is null) return View("Error", "home");
            _context.BlogComments.Remove(comment);
            Task<int> a = _context.SaveChangesAsync();
            int b = a.Result;
            return RedirectToAction("index");
        }

        #endregion
    }
}
