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

            var blogs = _context.Blogs.Include(x => x.BlogComments).Include(x => x.BlogImage).Include(x => x.BlogTag).AsQueryable();

            if (isDeleted != null)
                blogs = blogs.Where(x => x.IsDeleted == isDeleted);

            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = pageSizeStr == null ? 3 : int.Parse(pageSizeStr);
            return View(PaginatedList<Blog>.Create(blogs, page, pageSize));


        }
        public IActionResult Create()
        {
            ViewBag.BlogTags = _context.BlogTags.ToList();


            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            ViewBag.BlogTags = _context.BlogTags.ToList();


            if (!ModelState.IsValid)
                return View();

            if (blog.BlogImage == null)
            {
                ModelState.AddModelError("BlogImage", "Image is required");
                return View();
            }


            //if (!_context.BlogTags.Any(x => x.Id == blog.Tags.Id))
            //{
            //    ModelState.AddModelError("Blog", "Blog not found");
            //    return View();
            //}


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
        //public IActionResult Edit(int id)
        //{
        //    Product product = _context.Products.Include(x => x.Brand).Include(x => x.Type).Include(x => x.Gender).Include(x => x.ProductColors).ThenInclude(x => x.Color).FirstOrDefault(x => x.Id == id);

        //    if (product is null) return View("_ErrorPartialView");

        //    ViewBag.Brand = _context.Brands.Where(x => !x.IsDeleted).ToList();
        //    ViewBag.Gender = _context.Genders.ToList();
        //    ViewBag.Category = _context.Types.ToList();
        //    ViewBag.Color = _context.Colors.ToList();


        //    return View(product);

        //}
        //[HttpPost]
        //public IActionResult Edit(Product product)
        //{
        //    Product existproduct = _context.Products.Include(x => x.Brand).Include(x => x.ProductColors).Include(x => x.ProductImages).Include(x => x.Type).Include(x => x.Gender).FirstOrDefault(x => x.Id == product.Id);

        //    if (existproduct == null)
        //        return NotFound();

        //    if (!_context.Genders.Any(x => x.Id == product.GenderId))
        //    {
        //        ModelState.AddModelError("GenreId", "Genre not found");
        //        return View();
        //    }
        //    if (!_context.Brands.Any(x => x.Id == product.BrandId && !x.IsDeleted))
        //    {
        //        ModelState.AddModelError("AuthorId", "Author not found");
        //        return View();
        //    }


        //    if (product.PosterFile != null && product.PosterFile.ContentType != "image/jpeg" && product.PosterFile.ContentType != "image/png")
        //    {
        //        ModelState.AddModelError("PosterFile", "file type must be image/jpeg or image/png");
        //        return View();
        //    }

        //    if (product.PosterFile != null && product.PosterFile.Length > 2097152)
        //    {
        //        ModelState.AddModelError("PosterFile", "file size must be less than 2mb");
        //        return View();
        //    }

        //    ProductImage poster = existproduct.ProductImages.FirstOrDefault(x => x.ProductStatus == true);

        //    if (product.PosterFile != null)
        //    {
        //        string newPoster = FileManager.Save(_env.WebRootPath, "uploads/products", product.PosterFile);
        //        if (poster != null)
        //        {
        //            FileManager.Delete(_env.WebRootPath, "uploads/books", existproduct.ProductImages.FirstOrDefault(x => x.ProductStatus == true).Image);
        //            poster.Image = newPoster;
        //        }
        //        else
        //        {
        //            poster = new ProductImage { Image = newPoster, ProductStatus = true };
        //            existproduct.ProductImages.Add(poster);

        //        }

        //    }
        //    if (product.ColorIds != null)
        //    {
        //        existproduct.ProductColors.RemoveAll(x => !product.ColorIds.Contains(x.Id));
        //        foreach (var colors in product.ColorIds)
        //        {
        //            ProductColor color = new ProductColor
        //            {
        //                ProductId = product.Id,
        //                ColorId = colors
        //            };
        //            existproduct.ProductColors.Add(color);
        //        }
        //    }

        //    existproduct.ProductImages.RemoveAll(x => x.ProductStatus == null && !product.FileIds.Contains(x.Id));

        //    existproduct.BrandId = product.BrandId;
        //    existproduct.GenderId = product.GenderId;
        //    existproduct.CostPrice = product.CostPrice;
        //    existproduct.SalePrice = product.SalePrice;
        //    existproduct.TypeId = product.TypeId;
        //    existproduct.IsAvaiable = product.IsAvaiable;
        //    existproduct.Name = product.Name;
        //    existproduct.Desc = product.Desc;
        //    existproduct.ModifiedAt = DateTime.UtcNow.AddHours(4);
        //    existproduct.ColorIds = product.ColorIds;

        //    _context.SaveChanges();


        //    return RedirectToAction("index");
        //}
        //public IActionResult Delete(int id)
        //{

        //    Product existProd = _context.Products.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        //    if (existProd == null) return View("Error");
        //    existProd.IsDeleted = true;
        //    _context.SaveChanges();
        //    return RedirectToAction("index");

        //}
        //public IActionResult Restore(int id)
        //{
        //    Product existProd = _context.Products.FirstOrDefault(x => x.Id == id && x.IsDeleted);
        //    if (existProd == null) return View("Error");
        //    existProd.IsDeleted = false;
        //    _context.SaveChanges();

        //    return RedirectToAction("index");
        //}

    }
}
