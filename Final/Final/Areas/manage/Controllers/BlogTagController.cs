using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.Controllers
{

    public class BlogTagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
