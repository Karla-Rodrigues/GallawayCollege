using KarlaR_300997958.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;


namespace KarlaR_300997958.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AdminController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;

        }

        // LOGIN  //

        [HttpGet]
        [AllowAnonymous]
        public ViewResult Login(string returnUrl)
        {
            return View(new FacultyUsers {ReturnUrl = returnUrl});    
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(FacultyUsers facultyUsers)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(facultyUsers.Name);
                
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user, facultyUsers.Password, false, false)).Succeeded)
                    {
                        ViewBag.User = HttpContext.User.Identity.Name;
                        ViewBag.UserType = HttpContext.User.Identity.AuthenticationType;
                        return Redirect(facultyUsers?.ReturnUrl ?? "/Home/Index" + "");        
                    }
                }
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(facultyUsers);
        }
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            ViewBag.User = "Not Login";
            await signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }
    }
}
