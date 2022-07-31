using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JobList.Controllers
{
   
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string email,string password)
        {
            Context c = new Context();
            var datavalue = c.Employers.FirstOrDefault(x => x.Mail == email && x.Password==password);
            var datavalue2 = c.Employees.FirstOrDefault(x => x.Mail == email && x.Password==password);
            var datavalue3 = c.Admins.FirstOrDefault(x => x.Mail == email && x.Password==password);
            if (datavalue2 != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name,email),
                    new Claim(ClaimTypes.Role,"Employee")
                };
                var userIdentity = new ClaimsIdentity(claims, "b");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            else if (datavalue != null)
            {
                var claims = new List<Claim> { 
                    new Claim(ClaimTypes.Name,email),
                    new Claim(ClaimTypes.Role,"Employer")
                };
                var userIdentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            else if (datavalue3 != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name,email),
                    new Claim(ClaimTypes.Role,"Admin")
                };
                var userIdentity = new ClaimsIdentity(claims, "c");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Admin");
            }
            else { return View(); }
        }
       
    }
}
