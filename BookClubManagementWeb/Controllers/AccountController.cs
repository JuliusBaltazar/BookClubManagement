using BookClubManagementWeb.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookClubManagementWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                //Success. Create temp cookie to store
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, model.FullName),
                    new Claim(ClaimTypes.Role, "")
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));
                return RedirectToAction("SecurePage");
            }

            return View(model);
        }

        

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO. Call API
                var userFullName = model.UserName;
                var userId = string.Empty;
                switch(model.UserName.ToLower())
                {
                    case "booklover1":
                        userFullName = "Alice Johnson";
                        userId = "1";
                        break;
                    case "literaturefan":
                        userFullName = "Bob Smith";
                        userId = "2";
                        break;
                    case "novelenthusiast":
                        userFullName = "Charlie Brown";
                        userId = "3";
                        break;
                    default:
                        ModelState.AddModelError("", "There is no account registered under this username.");
                        return View(model);
                        break;

                }

                //Success. Create temp cookie to store
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, userFullName),
                    new Claim(ClaimTypes.Role, userId)
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));
                return RedirectToAction("SecurePage");
            }
            return View(model);
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Home");
        }

        [Authorize]
        public IActionResult SecurePage()
        {
            ViewBag.Name = HttpContext.User.Identity.Name;
            ViewBag.Id = "";
            var claimsPrincipal = HttpContext.User;
            if (claimsPrincipal != null)
            {
                var identity = claimsPrincipal.Identity as ClaimsIdentity;
                ViewBag.Id = identity.FindFirst(ClaimTypes.Role)?.Value;
                return RedirectToAction("UserProfile", "User");
            }

            return View();
        }

        
    }
}
