using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Uyumsoft.Controllers
{
    public class AdvertController : Controller
    {
        AdvertManager advertManager = new AdvertManager(new EFAdvertDal());
        public IActionResult Index()
        {            
            var values = advertManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAdvert() { 

            return View(); 

        }
        [HttpPost]
        public IActionResult AddAdvert(Advert a)
        {
            a.IsApproved = true;
            a.CompetenceID = 1;
            a.Salary = "5500";
            a.SectorID = 12;
            a.CityID = 34;
            a.Deadline = DateTime.Now;
            a.EmployerID = 1;
            a.OnlineHybridID = 2;
            a.WayOfWorkID = 3;
            advertManager.AddAdvert(a);
            return RedirectToAction("Index","Home");

        }
    }
}
