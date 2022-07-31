using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobList.Controllers
{
    public class AdminController : Controller
    {
        AdvertManager advertManager = new AdvertManager(new EFAdvertDal());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = advertManager.GetAllAdvertsWithErForAdmin();            
            return View(values);
        }

        public void UpdateAdvertStatus(int id)
        {
            Advert advert = advertManager.GetById(id);
            advert.IsApproved = !advert.IsApproved;
            advertManager.UpdateAdvert(advert);

        }
    }
}
