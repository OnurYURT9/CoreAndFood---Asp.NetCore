using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace CoreAndFood.Controllers
{
	public class LoginController : Controller
	{
		Context c = new Context();

		[AllowAnonymous]  //login sayfası authorize işleminden devre dışı bırakıldı.
		public IActionResult Index()
		{
			return View();
		}


        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Idare p)
        {
            var datavalue = c.Idares;
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Idarekullaniciadi)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
