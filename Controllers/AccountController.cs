using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intex.Models;
using Intex.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Intex.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        private ICrashRepository repo { get; set; }

        public AccountController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            userManager = um;
            signInManager = sim;
        }



        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            if (!String.IsNullOrEmpty(returnUrl)){
                return View(new LoginModel { ReturnUrl = returnUrl });
            }
            else
            {
                return View(new LoginModel { ReturnUrl = "/Home/AdminTable" });
            }
                
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginModel.Username);

                if (user != null)
                {
                    await signInManager.SignOutAsync();

                    if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/Home/AdminTable");
                    }
                }

            }

            ModelState.AddModelError("", "Invalid name or password");

            return View(loginModel);

        }

        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();

            return Redirect(returnUrl);
        }
    }
}
