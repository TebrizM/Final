using Final.Models;
using Microsoft.AspNetCore.Hosting;
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
    public class BlogController : Controller
    {
        private readonly HnBandContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(HnBandContext contex, IWebHostEnvironment env)
        {
            _context = contex;
            _env = env;
        }
        public IActionResult Index(int page = 1, bool? isDeleted = null)
        {
            ViewBag.IsDeleted = isDeleted;

            var blogs = _context.Blogs.Include(x=>x.BlogTags).AsQueryable();

            if (isDeleted != null)
                blogs = blogs.Where(x => x.IsDeleted == isDeleted);

            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = pageSizeStr == null ? 3 : int.Parse(pageSizeStr);
            return View(PaginatedList<Blog>.Create(blogs, page, pageSize));


        }
        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tags.ToList();


            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            ViewBag.Tags = _context.Tags.ToList();


            if (!ModelState.IsValid)
                return View();

            if (blog.BlogImage == null)
            {
                ModelState.AddModelError("BlogImage", "Image is required");
                return View();
            }


            blog.BlogTags = new List<BlogTags>();


            if (blog.TagIds != null)
            {
                foreach (var item in blog.TagIds)
                {
                    if (_context.Tags.Any(x => x.Id == item))
                    {
                        BlogTags blogTags = new BlogTags
                        {
                            TagsId = item,

                        };
                        blog.BlogTags.Add(blogTags);
                    }
                    else
                    {
                        ModelState.AddModelError("TagIds", "Tag not Found with Id" + item);
                        return View();
                    }
                }
            }


            blog.Image = Guid.NewGuid().ToString() + blog.BlogImage.FileName;

            string path = Path.Combine(_env.WebRootPath, "uploads/blogs", blog.Image);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                blog.BlogImage.CopyTo(stream);
            }

           
            _context.Blogs.Add(blog);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
           Blog blog = _context.Blogs.Include(x=>x.BlogTags).FirstOrDefault(x => x.Id == id);

            if (blog is null) return View("_ErrorPartialView");

            ViewBag.Tags = _context.Tags.ToList();

            blog.TagIds = blog.BlogTags.Select(x => x.TagsId).ToList();


            return View(blog);

        }
        [HttpPost]
        public IActionResult Edit(Blog blog)
        {
            Blog existblog = _context.Blogs.FirstOrDefault(x => x.Id == blog.Id);

            if (existblog == null)
                return NotFound();

            blog.BlogTags = new List<BlogTags>();


            if (blog.TagIds != null)
            {
                foreach (var item in blog.TagIds)
                {
                    if (_context.Tags.Any(x => x.Id == item))
                    {
                        BlogTags blogTags = new BlogTags
                        {
                            TagsId = item,

                        };
                        blog.BlogTags.Add(blogTags);
                    }
                    else
                    {
                        ModelState.AddModelError("TagIds", "Tag not Found with Id" + item);
                        return View();
                    }
                }
            }
            if (blog.BlogImage != null)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                if (existblog.Image != null)
                {
                    string oldPath = Path.Combine(_env.WebRootPath, "uploads/blogs", existblog.Image);

                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }


                if (blog.BlogImage.ContentType != "image/jpeg" && blog.BlogImage.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "file type must be image/jpeg or image/png");
                    return View();
                }
                if (blog.BlogImage.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "file size must be less than 2mb");
                    return View();
                }

                blog.Image = Guid.NewGuid().ToString() + blog.BlogImage.FileName;

                string path = Path.Combine(_env.WebRootPath, "uploads/blogs", blog.Image);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    blog.BlogImage.CopyTo(stream);
                }

                existblog.Image = blog.Image;

            }

            existblog.Desc = blog.Desc;
            existblog.BlogTags = blog.BlogTags;
            existblog.TagIds = blog.TagIds;
            existblog.Quote = blog.Quote;
            existblog.Name = blog.Name;
            existblog.ModifiedAt = DateTime.UtcNow.AddHours(4);


            _context.SaveChanges();


            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            Blog existBlog = _context.Blogs.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existBlog == null)
                return NotFound();

            //ViewBag.Genres = _context.Genres.Where(x => !x.IsDeleted).Where(x => x.LiquorFlavorId == id).ToList();

            //foreach (var product in ViewBag.Products)
            //{
            //    product.IsDeleted = true;
            //}

            existBlog.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        //RESTORE ACTION
        public IActionResult Restore(int id)
        {
            Blog existBlog = _context.Blogs.FirstOrDefault(x => x.Id == id && x.IsDeleted);

            if (existBlog == null)
                return NotFound();

            //ViewBag.Products = _context.Products.Where(x => x.IsDeleted).Where(x => x.LiquorFlavorId == id).ToList();

            //foreach (var product in ViewBag.Products)
            //{
            //    product.IsDeleted = false;
            //}

            existBlog.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }

    }
}
