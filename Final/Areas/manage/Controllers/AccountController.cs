using Final.Areas.manage.ViewModels;
using Final.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.Controllers
{
    [Area("manage")]

    public class AccountController : Controller
    {
        private readonly HnBandContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(HnBandContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        //public async Task<IActionResult> test()
        //{
        //    AppUser appUser = new AppUser
        //    {
        //        FullName = "Super Admin",
        //        UserName = "SuperAdmins",
        //        Email = "superadmin@gmail.com"
        //    };

        //    var result = await _userManager.CreateAsync(appUser, "Admins1234");

        //    return Ok(result.Errors);
        //}

        public async Task<IActionResult> Test()
        {
            //var result1 = await _roleManager.CreateAsync(new IdentityRole("Admin"));
            //var result2 = await _roleManager.CreateAsync(new IdentityRole("Member"));
            //var result3 = await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));

            AppUser admin = await _userManager.FindByNameAsync("SuperAdmins");

            var result = await _userManager.AddToRoleAsync(admin, "SuperAdmin");

            return Ok();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return View();

            AppUser admin = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == loginVM.UserName && x.IsAdmin);

            if (admin == null)
            {
                ModelState.AddModelError("", "UserName or Password is incorrect");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(admin, loginVM.Password, loginVM.IsPersistent, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Password is incorrect");
                return View();
            }

            return RedirectToAction("index", "dashboard");
        }
    }
}
